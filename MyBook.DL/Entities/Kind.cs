using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace MyBook.DL.Entities
{
    public class Kind
    {
        [Key]
        public int Id { get; set; }

        [MinLength(3)]
        [MaxLength(40)]
        [Required]
        public string Name { get; set; }
    }
}
