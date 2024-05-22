using System.ComponentModel.DataAnnotations.Schema;

namespace BaiThucHanh.Models;
[Table("Student")]
public class Student
{
    public string StudentID {get; set;}
    public string FullName {get; set;}
    public string Address { get; set; }
}