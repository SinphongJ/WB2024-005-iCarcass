using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WB2024_005_iCarcass.Models;

namespace WB2024_005_iCarcass.Controllers{

public class PlantSlocController : Controller
{
    public IActionResult Index(){
        
        return View();
    }
    public IActionResult Index2(){
        
        return View();
    }
    public IActionResult ConfigPlantV1(){
        
        return View();
    }
    public IActionResult OpenCardSloc( string data){
        var openCardSloc = data;
        
        return View("ConfigPlantV1",openCardSloc);
    }
    
    public IActionResult OpenCardAP( string datasloc, string dataap){
        var openCardAP = dataap;
         var openCardSloc = datasloc;
        
        return View("ConfigPlantV1",openCardAP);
    }
    public IActionResult OpencardAddPlant( int data){
        var opencardAddPlant = data;
        
        return View("Index",opencardAddPlant);
    }
    public IActionResult Plant(){
        return View();
    }

        public IActionResult Sloc(){
        return View();
    }
    public IActionResult OpencardAddSloc( string datasloc){
        var opencardAddSloc = datasloc;
        
        return View("Sloc",opencardAddSloc);
    }
    public IActionResult OpencardSlocZAP( int data){
        var opencardSlocZAP = data;
        
        return View("Sloc",opencardSlocZAP);
    }
    public IActionResult ConfigPlant(){
        
        return View();
    }
    public IActionResult ConfigPlantAP(){
        
        return View();
    }
    public IActionResult CreatePlant(){
        
        return View();
    }
    public IActionResult CreatePlantMe(){
        
        return View();
    }
    public IActionResult CreatePlantSAP(){
        
        return View();
    }
    public IActionResult CreatePlantSloc(){
        
        return View();
    }
    public IActionResult CreatePlantAP(){
        
        return View();
    }
    public IActionResult CreatePlantselect(){
        
        return View();
    }
    public IActionResult CreatePlantSAPSloc(){
        
        return View();
    }
    
    public IActionResult CreateSloc(){
        
        return View();
    }
    public IActionResult CreateSlocSelect(){
        
        return View();
    }
    public IActionResult CreateSlocSelect2( string datasloc){
        if(datasloc=="Car"){
                    return View("CreateSlocCar");
        }
        return View("CreateSlocOther");
    }
    
    public IActionResult CreateSlocCar(){
        
        return View();
    }public IActionResult CreateSlocCarSelect(){
        
        return View();
    }
    public IActionResult CreateSlocOther(){
        
        return View();
    }
    public IActionResult CreateSlocAP(){
        
        return View();
    }
    
    public IActionResult ReportPlant(){
        
        return View();
    }
    }
}
