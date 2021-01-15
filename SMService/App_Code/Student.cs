using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Summary description for Student
/// </summary>

[DataContract]
public class Student
{
    [DataMember]
    public string StudentId { get; set; }

    [DataMember]
    public string Name { get; set; }

    [DataMember]
    public DateTime BirthDay { get; set; }

    [DataMember]
    public string Gender { get; set; }

    [DataMember]
    public string Email { get; set; }

    [DataMember]
    public string Desciption { get; set; }

}
