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
    public class SupplierBulkRepo :GenericBulkExtension<Supplier> ,ISupplierBulkRepo<Supplier>
    {
        public SupplierBulkRepo(InventoryManagementDB context) : base(context)
        {
        }
    }
}
