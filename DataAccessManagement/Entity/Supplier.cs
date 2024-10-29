using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessManagement.Entity;

    public class Supplier
    {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    [StringLength(50 ,MinimumLength =3)]
    public string Name { get; set; }
    [Required]
    [StringLength(50 ,MinimumLength =3)]
    public string Address  { get; set; }
}

