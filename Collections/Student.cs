﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Pin { get; set; }

        public string GetDetails()
        {
            return ($"Name : {Name} Surname : {Surname} Pin :{Pin}");

        }




    }
}
