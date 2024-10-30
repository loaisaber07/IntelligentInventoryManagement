using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessManagement.ReadOperationInterfaceRepo;

    public interface IInventoryItemRepo<TEntity , TKey>: IGenericReadOperation<TEntity, TKey> where TEntity : class
    {
    }

