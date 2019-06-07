using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBook.DL.Abstract;
using MyBook.DL.Entities;

namespace MyBook.DL.Concrete
{
    public class EFRoleRepository: IRoleRepository
    {
        EFDbContext context = new EFDbContext();

        public IEnumerable<Role> Roles
        {
            get { return context.Roles; }
        }
    }
}
