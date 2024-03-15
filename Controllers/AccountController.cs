using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WB2024_005_iCarcass.Models;

namespace WB2024_005_iCarcass.Controllers{

public class AccountController : Controller
{
    public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
    public  IActionResult Index(Member member)
        {
            if (member.userName =="admin" && member.passWord=="123569") 
              {    return RedirectToAction("Index","Home");
                }
    return View(member);
    		
        }

		public IActionResult ErrorForbidden()
		{
			return View();
		}

    public IActionResult Autrorize()
    {
        return View();
    }
    public IActionResult CreateAuthorized(){
        return View();
    }

    public IActionResult EditAuthorized(){
        return View();
    }
    public  IActionResult Logout()
		{
			return RedirectToAction("Index", "Account");
		}
}
}