using UserList.Models.Objects;

namespace UserList.Models.Repositories
{
    internal sealed class RepositoryProvider : IRepositoryProvider<User>
    {
        private readonly XMLRepository repository = new XMLRepository();

        public IRepository<User> Repository => repository;
    }
}