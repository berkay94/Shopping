using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shopping.DAL;
namespace Shopping.REP
{
   public class Repositories
    {
        public class CategoriesRepository : BaseRepository<Categories> { }
        public class ProductsRepository : BaseRepository<Products> { }
        public class SuppliersRepository : BaseRepository<Suppliers> { }
        public class EmployeesRepository : BaseRepository<Employees> { }
    }
}
