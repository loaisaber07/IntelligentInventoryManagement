﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessManagement.WriteOperationInterfaceRepo
{
    public interface ISupplierBulkRepo<TEntity>: IGenericBulkExtension<TEntity> where TEntity : class
    {
    }
}
