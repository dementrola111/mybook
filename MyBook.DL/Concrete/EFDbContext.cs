using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBook.DL.Entities;
using System.Data.Entity;

namespace MyBook.DL.Concrete
{
    public class EFDbContext: DbContext
    {
        public DbSet<Article> Articles { get; set;}
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Kind> Kinds { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        //public DbSet<CategoryArticle> CategoriesArticles { get; set; }
    }
}
