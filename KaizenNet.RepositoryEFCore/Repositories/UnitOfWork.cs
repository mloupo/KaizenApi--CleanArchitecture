using KaizenNet.Entities.Interfaces;
using KaizenNet.RepositoryEFCore.DataContext;

namespace KaizenNet.RepositoryEFCore.Repositories
{
    internal class UnitOfWork : IUnitOfWork
    {
        readonly KaizenNetContext Context;
        public UnitOfWork(KaizenNetContext context) =>
            Context = context;
        public Task<int> SaveChanges()
        {
            //Aca deberiamos añadir un Try Catch
            //para manejar cualquier Exception que se genere.

            return Context.SaveChangesAsync();
        }
    }
}
