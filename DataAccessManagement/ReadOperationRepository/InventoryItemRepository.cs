using DataAccessManagement.Entity;
using DataAccessManagement.MainDataBase;
using DataAccessManagement.ReadOperationInterfaceRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessManagement.ReadOperationRepository;

    public class InventoryItemRepository :GenericReadOperation<InventoryItem,int>,IInventoryItemRepo<InventoryItem ,int>
    {
    private readonly InventoryManagementDB context;

    public InventoryItemRepository(InventoryManagementDB context) : base(context)
    {
        this.context = context;
    }

}

