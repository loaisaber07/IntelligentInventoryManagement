using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessManagement.WriteOperationInterfaceRepo;

    public interface IGenericWriteRepo<TEntity> where TEntity : class
    { 
        bool Add(TEntity entity);
        bool Remove(TEntity entity);
        bool Update(TEntity entity);                                       
    }

