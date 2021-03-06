﻿using DigitaltTestVerktygGrupp6Wpf.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitaltTestVerktygGrupp6Wpf.Model
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool SendTo { get; set; }
        public string Grade { get; set; } = "EG";
        public int ID { get; set; }
        public Student(dbStudent student)
        {
            FirstName = student.FirstName;
            LastName = student.LastName;
            Email = student.Email;
            ID = student.dbStudentId;
            SendTo = false;
        }
    }
}
