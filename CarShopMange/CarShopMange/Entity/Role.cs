using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShopMange.Entity
{
    
    public class Role
    {
        [Required(ErrorMessage ="Role Id is required.")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int roleID { get; set; }
        [Required(ErrorMessage = "Role name is required.")]
        public string roleName { get; set; }
        public ICollection<UserRole> userRole { get; set; }

    }
}
