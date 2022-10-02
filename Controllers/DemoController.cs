using Microsoft.AspNetCore.Mvc;
using BaiTap_B6.Models;
namespace BaiTap_B6.Controllers
{
    public class Democontroller : Controller
    {
        StringProcess strPro = new StringProcess();
        public IActionResult XuLyChuoi()
        {
            return View();
        }
        [HttpPost]
        public IActionResult XuLyChuoi(string strInput)
        {
            ViewBag.thongtin = strPro.RemoveReaminingWhiteSpace(strInput);
            return View();
        }
    }
}