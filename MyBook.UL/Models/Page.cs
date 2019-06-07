using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBook.UL.Models
{
    public class Page
    {
        /// <summary>
        /// Количество статей
        /// </summary>
        public int totalArticles { get; set; }

        /// <summary>
        /// Количество статей на одной странице
        /// </summary>
        public int amountPerPage { get; set; }
        
        /// <summary>
        ///Номер выбранной страницы
        /// </summary>
        public int currentPage { get; set; }
        
        /// <summary>
        ///Итоговое число страниц
        /// </summary>
        public int TotalPages
        {
            get
            {
                return (int)Math.Ceiling((decimal)totalArticles / amountPerPage);
            }
        }
    }
}