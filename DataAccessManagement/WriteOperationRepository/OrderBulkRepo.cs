using DataAccessManagement.Entity;
using DataAccessManagement.MainDataBase;
using DataAccessManagement.WriteOperationInterfaceRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessManagement.WriteOperationRepository;

    public class OrderBulkRepo : GenericBulkExtension<Order>, IOrderBulkRepo<Order>
    {
        public OrderBulkRepo(InventoryManagementDB context) : base(context)
        {
            
        }
    }

