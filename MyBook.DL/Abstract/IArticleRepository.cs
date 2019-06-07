using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBook.DL.Entities;

namespace MyBook.DL.Abstract
{
    public interface IArticleRepository
    {
        IEnumerable<Article> Articles { get; }

      ///  IEnumerable<Article> GetAllArticles { get;  }

    }
}
