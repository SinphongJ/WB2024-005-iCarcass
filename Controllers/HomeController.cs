using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WB2024_005_iCarcass.Models;

namespace WB2024_005_iCarcass.Controllers{
    public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
public IActionResult Index2()
    {
        return View();
    }
    public IActionResult ClosePeriod()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

}

