using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyBook.DL.Abstract;
using MyBook.DL.Entities;
using MyBook.UL.Models;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Text;



namespace MyBook.UL.Controllers
{
    public class HomeController : Controller
    {
        private IArticleRepository artRepository;
        private IAuthorRepository authRepository;
        private IBookRepository bookRepository;
        private ICategoryRepository categoryRepository;
        private ICommentRepository commentRepository;
        private IKindRepository kindRepository;
        private IRoleRepository roleRepository;
        private IUserRepository userRepository;
        //private ICategoryArticleRepository cRepisitory;
        public int pageSize = 3;

        public HomeController(IArticleRepository artRepo, IAuthorRepository auRepo, 
                              ICategoryRepository ctRepo, IBookRepository bRepo, 
                              IKindRepository kRepo, IRoleRepository rRepo, 
                              IUserRepository uRepo, ICommentRepository cmRepo
            //                  ICategoryArticleRepository caRepo
            )
        {                                                                                                                              
            artRepository = artRepo;
            authRepository = auRepo;
            bookRepository = bRepo;
            categoryRepository = ctRepo;
            commentRepository = cmRepo;
            kindRepository = kRepo;
            roleRepository = rRepo;
            userRepository = uRepo;
            //caRepisitory = caRepo;
        }

        

        // GET: Home
        public ViewResult Index(string category, int page = 1)
        {
            var itog =
             from a in artRepository.Articles
             from c in a.Categories
             where category == null || c.Name == category
             select a;

            ArticleIndexViewModels model = new ArticleIndexViewModels
            {
                Articles = artRepository.Articles
                    .OrderBy(a => a.Id)
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize),
                
                Page = new Page
                {
                    amountPerPage = pageSize,
                    currentPage = page,
                    totalArticles = artRepository.Articles.Count()
                },

                CurrentCategory = category



            };
            return View(model);
        }


    }
}