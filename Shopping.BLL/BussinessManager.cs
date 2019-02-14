using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shopping.REP;
using Shopping.BLL.DTOs;
namespace Shopping.BLL
{
    public class BussinessManager
    {
        public class CategoriesManager : Repositories.CategoriesRepository
        {
            public List<CategoriesDTOs> KategoriListele()
            {
                return GenelListe().Select(x => new CategoriesDTOs
                {
                    CategoryId = x.CategoryID,
                    CategoryName = x.CategoryName
                }).ToList();
            }
        }

        public class ProductManager:Repositories.ProductsRepository
        {
            public List<ProductsDTO> UrunListele()
            {
                return GenelListe().Select(x => new ProductsDTO
                {
                    ProductId = x.ProductID,
                    CategoryId = (int)x.CategoryID,
                    ProductName = x.ProductName,
                    UnitPrice=(decimal)x.UnitPrice
                }).ToList();
            }
        }
    }
}
