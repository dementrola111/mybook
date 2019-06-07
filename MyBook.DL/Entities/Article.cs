using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBook.DL.Entities
{
    public class Article
     {
        [Key]
        public int Id { get; set; }

        [MinLength(10)]
        [MaxLength(50)]
        [Required]
        public string Title { get; set; }

        [MinLength(20)]
        [Required]
        public string Annotation  { get; set; }

        [MinLength(20)]
        [Required]
        public string Text { get; set; }

        public DateTime Date { get; set; }

        public bool Publication { get; set; }

        [MinLength(10)]
        [Required]
        public string Keywords { get; set; }

        public  virtual ICollection<Category> Categories { get; set; }
       
    }
}
