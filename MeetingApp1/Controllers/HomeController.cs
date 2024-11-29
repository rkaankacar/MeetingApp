using MeetingApp1.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp1.Controllers
{
    public class HomeController: Controller //kalıtım yolu ile controller olma yetenbeği verdik
    {
        public IActionResult Index()
        {   
            
            string saat = DateTime.Now.ToString("HH:mm:ss");
            ViewBag.saat = saat; // m0del kullanmadan ekstra bilgi yollamızı sağğlar
            ViewBag.UserCount = Repository.Users.Where(i => i.WillAttend == true).Count();
            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "İstanbul,Atatürk Kongre Merkezi",
                Date = new DateTime(2024, 12, 20, 20, 0, 0),
                NumberOfPeople = ViewBag.UserCount
            };

            return View(meetingInfo);
        }
    }
}
