using DataAccessManagement.Entity;
using DataAccessManagement.MainDataBase;
using DataAccessManagement.ReadOperationInterfaceRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessManagement.ReadOperationRepository; 
    public class WarehouseReadRepository  : GenericReadOperation<Warehouse,int>, IWarehouseReadRepo<Warehouse,int>
    {
    private readonly InventoryManagementDB context;

    public WarehouseReadRepository(InventoryManagementDB context) : base(context)
    {
        this.context = context;
    }
}

