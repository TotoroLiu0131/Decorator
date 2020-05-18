using Decorator.Repositories;

namespace Decorator.Decorators
{
    public class RepoErrorHandler : BaseRepoDecorator
    {
        public RepoErrorHandler(IRepo repo) : base(repo)
        {
        }
    }
}