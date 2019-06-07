using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Web.Mvc;
using Moq;
using Ninject;
using MyBook.DL.Abstract;
using MyBook.DL.Entities;
using MyBook.DL.Concrete;


namespace MyBook.UL.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }


        /// <summary>
        /// реализация интерфейса - IDependencyResolver
        /// </summary>
        /// <param name="serviceType"></param>
        /// <returns></returns>
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        /// <summary>
        /// реализация интерфейса - IDependencyResolver
        /// </summary>
        /// <param name="serviceType"></param>
        /// <returns></returns>
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }


        /// <summary>
        /// Буду создавать привязки по мере необходимости
        /// </summary>
        private void AddBindings()
        {
            kernel.Bind<IArticleRepository>().To<EFArticleRepository>();
            kernel.Bind<IAuthorRepository>().To<EFAuthorRepository>();
            kernel.Bind<IBookRepository>().To<EFBookRepository>();
            kernel.Bind<ICategoryRepository>().To<EFCategoryRepository>();
            kernel.Bind<ICommentRepository>().To<EFCommentRepository>();
            kernel.Bind<IKindRepository>().To<EFKindRepository>();
            kernel.Bind<IRoleRepository>().To<EFRoleRepository>();
            kernel.Bind<IUserRepository>().To<EFUserRepository>();

        }
    }
}