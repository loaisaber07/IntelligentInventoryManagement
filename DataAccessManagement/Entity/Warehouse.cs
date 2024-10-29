using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessManagement.Entity;

    public class Warehouse
    {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    public String Location { get; set; }
    [Required]
    [StringLength(40 ,MinimumLength =3 , ErrorMessage ="Name must be between 3 and 40 characters")]
    public String Name { get; set; }
    [Required]
    [StringLength(40, MinimumLength = 3, ErrorMessage = "Description must be between 3 and 40 characters")]

    public String Description { get; set; }

    #region  InventoryItems Reference  
    [InverseProperty(nameof(InventoryItem.Warehouse))]
    public virtual ICollection<InventoryItem> InventoryItems { get; set; }
    #endregion
}

