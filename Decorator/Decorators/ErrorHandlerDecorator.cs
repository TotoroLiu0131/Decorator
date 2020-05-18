using System;
using Decorator.Repositories;

namespace Decorator.Decorators
{
    public class ErrorHandlerDecorator : BaseDecorator
    {
        public ErrorHandlerDecorator(IRepo repo) : base(repo)
        {
        }

        public override OrderDto Query()
        {
            var orderDto = base.Query();
            if (orderDto.ErrorCode != 0)
            {
                throw new Exception();
            }

            return orderDto;
        }
    }
}