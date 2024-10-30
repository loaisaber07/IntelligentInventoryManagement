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
    public class WareHouseBulkRepo :GenericBulkExtension<Warehouse> ,IWareHouseBulkRepo<Warehouse>
    {
        public WareHouseBulkRepo(InventoryManagementDB context) : base(context)
        {
            
        }
    }
}
