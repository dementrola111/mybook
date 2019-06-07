using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace MyBook.DL.Entities
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [MinLength(3)]
        [MaxLength(40)]
        [Required]
        public string Name { get; set; }

        [MaxLength(100)]
        [Required]
        public string Foto { get; set; }

        public Author Author { get; set; }
        public Kind Kind { get; set; }
    }
}
