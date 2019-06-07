using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace MyBook.DL.Entities
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public User Id_User { get; set; }
        public Article Id_Article { get; set; }

        [MinLength(10)]
        [Required]
        public string Text { get; set; }

    }
}
