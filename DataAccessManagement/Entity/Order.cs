using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessManagement.Entity;

    public  class Order
    {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set;}
    
    public DateTime Date { get; }
    [AllowedValues("Purcher","Sale")]
    [StringLength(10)]
    public string Type { get; set;}
    [AllowedValues("Pending", "Shipped", "Delivered", "Cancelled")]
    public int Status { get; set; }
    #region User Reference 
    public string UserId { get; set; }
    [ForeignKey(nameof(UserId))]
    public virtual User User { get; set; }
    #endregion
}

