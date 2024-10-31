
using DataAccessManagement.Entity;
using DataAccessManagement.ReadOperationInterfaceRepo;
using DataAccessManagement.ReadOperationRepository;
using DataAccessManagement.WriteOperationInterfaceRepo;
using DataAccessManagement.WriteOperationRepository;

namespace IntelligentInventoryManagement.IServiceCollectionExtension;

    public static class ServiceCollectionExtension
    {
    public static IServiceCollection AddReadRepositories(this IServiceCollection services)
    {
        services.AddScoped<IsupplierReadRepo<Supplier,int>, SupplierReadRepository>();
        services.AddScoped<IOrderReadOperation<Order, int>, OrderReadRepositoy>();
        services.AddScoped<IInventoryReadItemRepo<InventoryItem,int>, InventoryItemReadRepository>();
        services.AddScoped<IWarehouseReadRepo<Warehouse, int>, WarehouseReadRepository>();
        return services; 
    }
    public static IServiceCollection AddWriteRepositories(this IServiceCollection services)
    {
        services.AddScoped<IInventoryItemWriteRepo<InventoryItem>, InventoryItemWriteRepo>();
        services.AddScoped<IOrderWriteRepo<Order>, OrderWriteRepo>();
        services.AddScoped<IWareHouseWriteRepo<Warehouse>, WareHouseWriteRepo>();
        services.AddScoped<IInventoryItemWriteRepo<InventoryItem>, InventoryItemWriteRepo>();
        return services;
    }
    public static IServiceCollection AddBulkRepository(this IServiceCollection services)
    { 
    services.AddScoped<IInventoryItemBulkReop<InventoryItem>, InventoryItemBulkRepo>();
        services.AddScoped<IWareHouseBulkRepo<Warehouse>, WareHouseBulkRepo>();
        services.AddScoped<IOrderBulkRepo<Order>, OrderBulkRepo>();
    services.AddScoped<ISupplierBulkRepo<Supplier>, SupplierBulkRepo>();
        return services;
    }
}





