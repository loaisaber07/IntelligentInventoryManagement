using DataAccessManagement.Entity;
using DataAccessManagement.MainDataBase;
using DataAccessManagement.ReadOperationInterfaceRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessManagement.ReadOperationRepository;

    public class OrderReadRepositoy : GenericReadOperation<Order,int>, IOrderReadOperation<Order,int>
    {
    private readonly InventoryManagementDB context;

    public OrderReadRepositoy(InventoryManagementDB context) : base(context)
    {
        this.context = context;
    }
}

