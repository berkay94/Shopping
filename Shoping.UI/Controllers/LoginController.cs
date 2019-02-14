using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shopping.BLL.DTOs;
using Shoping.UI.Models.view;
using static Shopping.BLL.BussinessManager;
namespace Shoping.UI.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel m)
        {
            try
            {
                
            }
            catch (Exception)
            {

                throw;
            }

            return View();
        }
    }
}