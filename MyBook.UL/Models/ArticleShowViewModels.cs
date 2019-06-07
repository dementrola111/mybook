using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyBook.DL.Entities;


namespace MyBook.UL.Models
{
    public class ArticleShowViewModels
    {
        public IEnumerable<Article> Articles { get; set; }

    }
}