using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessManagement.ReadOperationInterfaceRepo; 
    public interface IGenericReadOperation<TEntity , TKey>  where TEntity :class
    {
     Task<IEnumerable<TEntity>>  GetAllAsync(); 
    Task<TEntity?> GetByIdAsync(TKey id);
    Task<IEnumerable< TEntity>> FindAsync(Expression< Func<TEntity, bool>> predicate);
    }

