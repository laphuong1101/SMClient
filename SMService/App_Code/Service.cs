using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    private WCFMyDbContext db = new WCFMyDbContext();
    public Student Add(Student student)
    {
        db.Students.Add(student);
        db.SaveChanges();
        return student;
    }

    public List<Student> GetStudents()
    {
        return db.Students.ToList();
    }

    public Student Update(string StudentID, string Name, DateTime BirthDay, string Gender, string Email, string Desc)
    {
        var student = db.Students.Find(StudentID);
        student.Name = Name;
        student.BirthDay = BirthDay;
        student.Gender = Gender;
        student.Email = Email;
        student.Desciption = Desc;
        db.SaveChanges();
        return student;
    }
}
