using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
namespace NewFine.Data.Repository
{
    public interface IRepositoryBase :IDisposable
    {
        IRepositoryBase BeginTrans();

        int Commit();

        int Insert<TEntity>(TEntity entity) where TEntity : class;
        int Insert<TEntity>(List<TEntity> entitys) where TEntity : class;
        int Update<TEntity>(TEntity entity) where TEntity : class;
        int Delete<TEntity>(TEntity entity) where TEntity : class;
        int Delete<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : class;
        TEntity FindEntity<TEntity>(object keyvalue) where TEntity : class;
        TEntity FindEntity<TEntity>(Expression<Func<TEntity, bool>>predicate
            ) where TEntity : class;
        IQueryable<Tentity> IQueryable<Tentity>() where Tentity : class;
    }
}
