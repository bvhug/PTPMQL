using Microsoft.AspNetCore.Mvc;

namespace BaiThucHanh.Controllers;
    public class EmployeeController : Controller
    {
         public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(string EmployeeID)
    {
        string strResult = "Xin chao" + EmployeeID ;
        ViewBag.Thongbao = strResult;
        return View();
    }
    }
