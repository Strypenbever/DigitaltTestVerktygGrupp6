﻿using DigitaltTestVerktygGrupp6Wpf.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitaltTestVerktygGrupp6Wpf.Model
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool SendTo { get; set; }
        public Student(dbStudent student)
        {
            FirstName = student.FirstName;
            LastName = student.LastName;
            SendTo = false;
        }
    }
}