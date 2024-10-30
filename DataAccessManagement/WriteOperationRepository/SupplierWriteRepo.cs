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
    public class SupplierWriteRepo  : GenericWriteRepo<Supplier>, ISupplierWriteRepo<Supplier> 
    {
        private readonly InventoryManagementDB context;

        public SupplierWriteRepo(InventoryManagementDB context) : base(context)
        {
            this.context = context;
        } 
    }
}
