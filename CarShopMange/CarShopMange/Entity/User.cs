using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShopMange.Entity
{
    public class User
    {
        [Key]
        [Required(ErrorMessage ="User Id is required.")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int userID { get; set; }
        [Required(ErrorMessage ="Username is required.")]
        public string userName { get; set; }
        [Required(ErrorMessage ="Email is required.")]
        [EmailAddress(ErrorMessage ="Email is not Valid")]
        public string email { get; set; }
        [Required(ErrorMessage ="Password is required")]
        [Range(6,32,ErrorMessage = "Password must be no less than 6 characters and no more than 32 characters")]
        public string password { get; set; }
        [Required(ErrorMessage ="User Role is required.")]
        public ICollection<UserRole> userRole { get; set; }
        
        public DateTime entryDate { get; set; }
        [Required(ErrorMessage ="Date of bith is required.")]
        public DateTime dateofBirth { get; set; }
        [RegularExpression(@"^\+?\d+$", ErrorMessage ="Phone number must be have id country and number.")]
        public string phoneNumber { get; set; }
    }
}
