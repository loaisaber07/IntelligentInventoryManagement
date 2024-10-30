using DataAccessManagement.Entity;
using DataAccessManagement.MainDataBase;
using DataAccessManagement.ReadOperationInterfaceRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessManagement.ReadOperationRepository;

   public class SupplierReadRepository : GenericReadOperation<Supplier,int>, IsupplierReadRepo<Supplier,int>
    {
    private readonly InventoryManagementDB context;

    public SupplierReadRepository(InventoryManagementDB context) : base(context)
    {
        this.context = context;
    }
}

