using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShopMange.Entity
{

    public class UserRole
    {
        [Required(ErrorMessage = "User ID is required.")]
        [ForeignKey("userID")]
        public int userID { get; set; }
        [Required(ErrorMessage = "Role is require")]
        [ForeignKey("roleID")]
        public int roleID { get; set; }
        public User user { get; set; }
        public Role role { get; set; }
    }
}
