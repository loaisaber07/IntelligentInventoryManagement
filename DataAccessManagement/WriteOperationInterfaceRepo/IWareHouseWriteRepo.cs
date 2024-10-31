using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessManagement.WriteOperationInterfaceRepo
{
    public interface IWareHouseWriteRepo<TEntity>:IGenericWriteRepo<TEntity> where TEntity : class
    {
    }
}
