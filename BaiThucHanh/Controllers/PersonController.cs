using Microsoft.AspNetCore.Mvc;
using BaiThucHanh.Models;
using BaiThucHanh.Data;
using Microsoft.EntityFrameworkCore;
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
        string strResult = "xin chao" + ps.PersonID + "-" + ps.FullName + "-" + ps.Address;
        ViewBag.Thongbao = strResult;
        return View();
    }
}