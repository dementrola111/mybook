using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBook.DL.Abstract;
using MyBook.DL.Entities;

namespace MyBook.DL.Concrete
{
    /// <summary>
    /// класс  для хранения об
    /// </summary>
    public class EFArticleRepository : IArticleRepository
    {
        EFDbContext context = new EFDbContext();
        public IEnumerable<Article> Articles
        {
            get
            {
                return context.Articles;
            }
        }

        //public IEnumerable<Article> GetAllArticles

        //{
        //    get
        //    {
        //        return context.Articles.Include("Categories").ToList();
        //    }
        //}
    }
}
