using DataAccessManagement.Entity;
using DataAccessManagement.MainDataBase;
using DataAccessManagement.WriteOperationInterfaceRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessManagement.WriteOperationRepository
{
    public class InventoryItemBulkRepo :GenericBulkExtension<InventoryItem> ,IInventoryItemBulkReop<InventoryItem>
    {
        public InventoryItemBulkRepo(InventoryManagementDB context) : base(context)
        {
            
        }
    }
}
