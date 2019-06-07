using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace MyBook.DL.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [MinLength(6)]
        [MaxLength(30)]
        [Required]
        public string Login { get; set; }

        [MinLength(8)]
        [MaxLength(50)]
        [Required]
        public string Password { get; set; }

        [MinLength(10)]
        [MaxLength(50)]
        [Required]
        public string Email { get; set; }

        public DateTime Date_registration { get; set; }
        public DateTime Date_birth { get; set; }
        


        public Role Id_role { get; set; } 

    }
}
