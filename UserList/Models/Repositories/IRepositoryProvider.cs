namespace UserList.Models.Repositories
{
    internal interface IRepositoryProvider<T>
    {
      IRepository<T>  Repository { get; }
    }
}