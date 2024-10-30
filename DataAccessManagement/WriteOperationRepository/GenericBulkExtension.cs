using DataAccessManagement.MainDataBase;
using DataAccessManagement.WriteOperationInterfaceRepo;
using EFCore.BulkExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessManagement.WriteOperationRepository
{
    public abstract class GenericBulkExtension<TEntity> : IGenericBulkExtension<TEntity> where TEntity : class
    {
        private readonly InventoryManagementDB context;

        protected GenericBulkExtension(InventoryManagementDB context)
        {
            this.context = context;
        }

        public async Task<bool> BulkDelete(IEnumerable<TEntity> entities)
        {
            using var transaction = await context.Database.BeginTransactionAsync();
                try
                {
                    await context
                        .BulkDeleteAsync<TEntity>(entities); 
                await transaction.CommitAsync();
                    return true;
                }
                catch
                { 
                    await transaction.RollbackAsync();
                    return false;
                }  
        }

        public async Task<bool> BulkInsert(IEnumerable<TEntity> entities)
        {
            using var transaction = await context.Database.BeginTransactionAsync();

            try
            {
                await context
                    .BulkInsertAsync<TEntity>(entities); 
                await transaction.CommitAsync();
                return true;
            }
            catch
            { 
                await transaction.RollbackAsync();
                return false;
            }

        }

        public async Task<bool>  BulkUpdate(IEnumerable<TEntity> entities)
        {
            using var transaction = await context.Database.BeginTransactionAsync();

            try
            {
                await context
                    .BulkUpdateAsync<TEntity>(entities);

                await transaction.CommitAsync();
                return true;
            }
            catch
            { 
                await transaction.RollbackAsync();
                return false;
            }

        }
    }
}
