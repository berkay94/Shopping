using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Shopping.BLL.DTOs;
namespace Shoping.UI.Models.view
{
    public class CategoryModel
    {
        public List<CategoriesDTOs> clist { get; set; }
        public List<ProductsDTO> plist { get; set; }

        public CategoryModel()
        {
            this.plist = new List<ProductsDTO>();
        }
    }
}