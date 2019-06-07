using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyBook.DL.Entities;

namespace MyBook.UL.Areas.Admin.Models
{
    public class ArticleListModels
    {
        public class ArticleIndexViewModels
        {
            public IEnumerable<Article> Articles { get; set; }
            /// <summary>
            /// Имя выбранной страницы
            /// </summary>
           

        }
    }
}