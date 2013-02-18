﻿using System;

namespace MvcApplication1.Models
{
    /*
    public class Person
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Person(string name, DateTime dateOfBirth)
        {
            this.Name = name;
            this.DateOfBirth = dateOfBirth;
        }
    }
    */
    public class Robot
    {
        public string Designation { get; set; }
        public DateTime ManufactureDate { get; set; }
        public bool KillMode { get; set; }

        public Robot(string designation, DateTime manufactureDate, bool killMode)
        {
            this.Designation = designation;
            this.ManufactureDate = manufactureDate;
            this.KillMode = killMode;
        }
    }
}