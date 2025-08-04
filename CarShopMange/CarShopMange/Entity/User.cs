using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShopMange.Entity
{
    class User
    {
        [Key]
        [Required(ErrorMessage ="User Id is required.")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int userId { get; set; }
        [Required(ErrorMessage ="Username is required.")]
        public string userName { get; set; }
        [Required(ErrorMessage ="Email is required.")]
        [EmailAddress(ErrorMessage ="")]
        public string email { get; set; }
    }
}
