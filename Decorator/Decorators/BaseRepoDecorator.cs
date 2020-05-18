using Decorator.Repositories;

namespace Decorator.Decorators
{
    public class BaseRepoDecorator : IRepo
    {
        private readonly IRepo _repo;

        public BaseRepoDecorator(IRepo repo)
        {
            _repo = repo;
        }

        public void Query()
        {
            _repo.Query();
        }
    }
}