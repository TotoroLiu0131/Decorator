using Decorator.Repositories;

namespace Decorator.Decorators
{
    public class BaseDecorator : IRepo
    {
        private readonly IRepo _repo;

        public BaseDecorator(IRepo repo)
        {
            _repo = repo;
        }

        public virtual OrderDto Query()
        {
            return _repo.Query();
        }
    }
}