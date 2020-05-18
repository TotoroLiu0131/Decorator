using Decorator.Repositories;
using Microsoft.Extensions.Configuration;

namespace Decorator.Decorators
{
    public class BusinessLogicDecorator : BaseDecorator
    {
        private readonly IConfiguration _configuration;

        public BusinessLogicDecorator(IConfiguration configuration,IRepo repo) : base(repo)
        {
            _configuration = configuration;
        }

        public override OrderDto Query()
        {
            var toggle = _configuration["WhateverToggle"];
            if (toggle == "True")
            {
                //do something or not
            }
            var orderDto = base.Query();
            return orderDto;
        }
    }
}