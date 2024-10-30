using DataAccessManagement.MainDataBase;
using DataAccessManagement.WriteOperationInterfaceRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessManagement.WriteOperationRepository;

public abstract class GenericWriteRepo<TEntity, TKey> : IGenericWriteRepo<TEntity> where TEntity : class
{
    private readonly InventoryManagementDB context;

    protected GenericWriteRepo(InventoryManagementDB context)
    {
        this.context = context;
    }
    public bool Add(TEntity entity)
    {
        try {
        context.Set<TEntity>()
                .Add(entity);
        return true;
        } 
        catch {
            return false; 
        }
    }

    public bool Remove(TEntity entity)
    {
        try
        {
            context.Set<TEntity>()
                    .Remove(entity);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool Update(TEntity entity)
    {
        try
        {
            context.Set<TEntity>()
                    .Update(entity);
            return true;
        }
        catch
        {
            return false;
        }
    }
}

