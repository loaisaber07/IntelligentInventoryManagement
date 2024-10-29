using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessManagement.Entity;

    public class OrderItem
    {
    public int OrderId { get; set; }
    public int ItemId { get; set; }
    [ForeignKey(nameof(OrderId))]
    public virtual Order Order { get; set; }
    [ForeignKey(nameof(ItemId))]
    public virtual InventoryItem Item { get; set; }
    [Range(1,50)]
    public int Quantity { get; set; }
    [Range(5,maximum:5000 ,ErrorMessage = "Price must be between 5 and 5000")]
    public int Price { get; set; }
}

