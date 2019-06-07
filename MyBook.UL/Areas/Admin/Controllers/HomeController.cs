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

namespace MyBook.UL.Areas.Admin.Controllers
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

        public HomeController(IArticleRepository artRepo, IAuthorRepository auRepo,
                              ICategoryRepository ctRepo, IBookRepository bRepo,
                              IKindRepository kRepo, IRoleRepository rRepo,
                              IUserRepository uRepo, ICommentRepository cmRepo
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

        }

        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Admin/Home/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Home/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Home/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Home/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
