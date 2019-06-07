using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBook.DL.Abstract;
using MyBook.DL.Entities;

namespace MyBook.DL.Concrete
{
    public class EFAuthorRepository : IAuthorRepository
    {
        EFDbContext context = new EFDbContext();

        public IEnumerable<Author> Authors 
            {
                get  { return context.Authors ; }
            }

    }
}
