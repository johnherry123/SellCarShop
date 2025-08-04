using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShopMange.Entity
{
   
    class UserRole
    {
        [Required(ErrorMessage ="User ID is required.")]
        [ForeignKey("userID")]
        public int userId { get; set; }
        [Required(ErrorMessage ="Role is require")]
        [EnumDataType(typeof(Role),ErrorMessage ="Invalid Role")]
        public Role role { get; set; }

    }
}
