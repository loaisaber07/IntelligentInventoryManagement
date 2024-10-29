using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessManagement.Entity; 

    public class User  :IdentityUser
    {
    #region Order Reference
    [InverseProperty(nameof(Order.User))]
    public virtual ICollection<Order> Orders { get; set; }
    #endregion

}

