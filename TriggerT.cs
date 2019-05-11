using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Automation.API.Controllers;
using Automation.API.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Core;
using Xunit;

namespace Automation.Test
{
    public class TriggerT
    {
        private readonly TriggersController _trigger;
        private readonly MetaDatasController _meta;
        private readonly ActionsController _action;
        private readonly ConditionsController _condition;
        private AutoContext _context;

        public TriggerT(AutoContext context)
        {
            _context = context;
        }
        [Fact]
        public async void AddAction()
        {
            var action = new API.Models.Action { 
                Type = "create",
                Value = "johnathan_13_LA"
            };
            var res = await _action.PostAction(action);
            Assert.IsType<CreatedAtActionResult>(res);
        }

        [Fact]
        public void AddCondition()
        {
        //Given
        
        //When
        
        //Then
        }

        [Fact]
        public void AddMeta()
        {
        //Given
        
        //When
        
        //Then
        }
        
        [Fact]
        public void ActionSetMeta()
        {
        //Given
        
        //When
        
        //Then
        }

        [Fact]
        public void ConditionSetMeta()
        {
        //Given
        
        //When
        
        //Then
        }

        [Fact]
        public void TriggerSetAction()
        {
        //Given
        
        //When
        
        //Then
        }

        [Fact]
        public void TriggerSetCondition()
        {
        //Given
        
        //When
        
        //Then
        }

        [Fact]
        public void TriggerGetQuery()
        {
        //Given
        
        //When
        
        //Then
        }
    }
}
