using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessManagement.Entity;  

    public class InventoryItem
    {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    [StringLength(50, MinimumLength = 5)]
    public string Name { get; set; }
    [Range(0,100)]
    [Required]
    public int Quantity { get; set;}
    [DataType(DataType.Date)]
    public DateTime ExpireDate {get; set;}
    [Required]
    public int ReorderThreshold {get; set;}

    #region  
    public int WarehouseId { get; set; }
    [ForeignKey(nameof(WarehouseId))]
    public virtual Warehouse Warehouse { get; set; } 
    #endregion
}

