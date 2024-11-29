using Microsoft.AspNetCore.Mvc;
using MeetingApp1.Models;

namespace MeetingApp1.Controllers
{
    public class MeetingController: Controller
    {
         // default olarak get requesttir
      

        public IActionResult Apply()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Apply(UserInfo model) // taghelperslarla modelle bilgi yolluyoruz
        {
            //databse
            //list vb. kayıt etme 
            if (ModelState.IsValid)
            {// true ise hiç bir değer null değildir ve program işlemeye devam eder deafult truedur
                Repository.CreateUser(model);
                ViewBag.UserCount = Repository.Users.Where(i => i.WillAttend == true).Count();
                return View("Index", model);
            }
            else 
            {
                return View(model);
            }
           
        }

        public IActionResult List() 
        {    
            return View(Repository.Users);
        }
         
        // meeting/details/2 bunu getirir
        public IActionResult Details(int id)
        {
            return View(Repository.GetById(id));
        }
    }
}
