using System.IO;
using System.Security.AccessControl;
using Internal;
using System;
namespace BaiThucHanh.Models;
{
    public class Employee
{
    public string EmployeeID {get; set;}
    public string FullName {get; set;}
    public int Age {get; set;}
    public int Luong {get; set;}
    public void EnterData()
    {
        System.Console.Write("EmployeeID = ");
        EmployeeID = Console.ReadLine();
        System.Console.Write("FullName = ");
        FullName = Console.ReadLine();
        System.Console.Write("Age = ");
        Age = Convert.ToInt16(Console.ReadLine());
    }
    public void Display()
    {
        System.Console.WriteLine("{0} - {1} - {2} tuoi")
    }
}
}