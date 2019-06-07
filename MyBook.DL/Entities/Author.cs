using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace MyBook.DL.Entities
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        [MinLength(3)]
        [MaxLength(40)]
        [Required]
        public string FirstName { get; set; }

        [MinLength(3)]
        [MaxLength(40)]
        [Required]
        public string LastName { get; set; }

        [MinLength(3)]
        [MaxLength(40)]
        [Required]
        public string Patronymic { get; set; }

        [MaxLength(150)]
        public string Foto { get; set; }
        public DateTime DataBirth { get; set; }

        [MinLength(10)]
        [Required]
        public string Biography { get; set; }

    }
}
