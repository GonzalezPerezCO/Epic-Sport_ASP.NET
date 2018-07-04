using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp_gym.Models
{
    public class Student: Person
    {
        public Student()
        {
        }

        public Student(string name, string lastname, int code, string career, int semester, bool enabled, string[][] calendar) 
            : base(name, lastname)
        {
            CodeS = code;
            Career = career;
            Semester = semester;
            Enabled = enabled;
            CalendarS = calendar;
        }

        public int CodeS { get; set; }
        public string Career { get; set; }
        public int Semester { get; set; }
        public bool Enabled { get; set; }
        public string[][] CalendarS { get; set; }
    }
}