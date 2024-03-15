using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WB2024_005_iCarcass.Models;

namespace WB2024_005_iCarcass.Controllers{

public class UserConfigController : Controller
{
    public IActionResult UserConfigPlantSloc(){
        return View();
    }
    
    public IActionResult ReportApprovePlantSloc(){
        return View();
    }
    
    public IActionResult ConfigApprovePlantSloc(){
        return View();
    }
    
    public IActionResult CheckdataApprove(string dataApprove){
        if(dataApprove=="ApproveSloc"){
                return View("ConfigApprovePlantSlocAP");
        }else{
            return View("ConfigApprovePlantSlocSelect");
        }
        
    }
    public IActionResult ConfigApprovePlantSlocSelect(){
        return View();
    }
    public IActionResult ConfigApprovePlantSlocAP(){
        return View();
    }
}

}