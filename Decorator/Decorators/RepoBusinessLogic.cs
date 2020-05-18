using Decorator.Repositories;

namespace Decorator.Decorators
{
    public class RepoBusinessLogic : BaseRepoDecorator
    {
        public RepoBusinessLogic(IRepo repo) : base(repo)
        {
        }
    }
}