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
    public class OrderWriteRepo :GenericWriteRepo<Order>, IOrderWriteRepo<Order>
    {
        public OrderWriteRepo(InventoryManagementDB context) : base(context)
        {
            
        }
    }
}
