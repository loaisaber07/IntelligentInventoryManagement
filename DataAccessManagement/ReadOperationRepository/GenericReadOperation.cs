using DataAccessManagement.MainDataBase;
using DataAccessManagement.ReadOperationInterfaceRepo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessManagement.ReadOperationRepository;

public abstract class GenericReadOperation<TEntity, TKey> : IGenericReadOperation<TEntity, TKey> where TEntity : class
{
    private readonly InventoryManagementDB context;

    protected GenericReadOperation(InventoryManagementDB context)
    {
        this.context = context;
    }
    public async Task<IEnumerable<TEntity>> FindAsync(Expression <Func<TEntity, bool>> predicate)
    {
        return  await context.Set<TEntity>()
                      .Where(predicate)
                      .ToListAsync(); 
            
    }

    

    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await context.Set<TEntity>()
               .ToListAsync();
    }

    public async Task<TEntity?> GetByIdAsync(TKey id)
    {
       return await context.Set<TEntity>().FindAsync(id);
    }
}

