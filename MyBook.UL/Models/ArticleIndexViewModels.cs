using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyBook.DL.Entities;

namespace MyBook.UL.Models
{
    public class ArticleIndexViewModels
    {
        public IEnumerable<Article> Articles { get; set; }
        /// <summary>
        /// Имя выбранной страницы
        /// </summary>
        public Page Page { get; set; }
        /// <summary>
        /// Имя выбранной категории
        /// </summary>
        public string CurrentCategory { get; set; }

    }
}