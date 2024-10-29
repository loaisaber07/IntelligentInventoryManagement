using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessManagement.Entity; 
    public class ItemSupplier
    {
    public int SupplierId { get; set; }
    public int ItemId { get; set; }
    [ForeignKey(nameof(SupplierId))]
    public virtual Supplier Supplier { get; set; }
    [ForeignKey(nameof(ItemId))]
    public virtual InventoryItem Item { get; set; }
}

