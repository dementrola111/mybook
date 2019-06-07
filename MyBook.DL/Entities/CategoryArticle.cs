using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace MyBook.DL.Entities
{
    public class CategoryArticle
    {
        [Key]
        public int Id { get; set; }

        public Category Id_category { get; set; }

        public Article Id_article { get; set; }
    }
}
