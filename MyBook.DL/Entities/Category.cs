using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace MyBook.DL.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [MinLength(3)]
        [MaxLength(40)]
        [Required]
        public string Name { get; set; }

        [MinLength(3)]
        [MaxLength(100)]
        [Required]
        public string Description { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
    }
}
