using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessManagement.WriteOperationInterfaceRepo
{
    public interface IGenericBulkExtension<TEntity> where TEntity :class
    { 
        Task<bool> BulkInsert(IEnumerable<TEntity> entities);
        Task<bool> BulkUpdate(IEnumerable<TEntity> entities);
        Task<bool> BulkDelete(IEnumerable<TEntity> entities);
    }
}
