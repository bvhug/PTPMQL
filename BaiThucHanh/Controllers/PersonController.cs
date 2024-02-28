using Microsoft.AspNetCore.Mvc;
using BaiThucHanh.Models;
namespace BaiThucHanh.Controllers;
public class PersonController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Welcome()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Welcome(Person ps)
    {
        ViewBag.Thongbao = "xin chao" + ps.PersonID + "-" + ps.FullName + "-" + ps.Address;
        return View();
    }
}