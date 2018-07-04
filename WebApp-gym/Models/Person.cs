using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp_gym.Models
{
    public class Person
    {
        public Person()
        {
        }

        public Person(string name, string lastname, int codeS, string career, bool enabled, string[][] calendarS)
        {
            Name = name;
            Lastname = lastname;
            CodeS = codeS;
            Career = career;

            Enabled = enabled;
            CalendarS = calendarS;
        }

        public String Name { get; set; }
        public String Lastname { get; set; }
        public int CodeS { get; set; }
        public String Career { get; set; }
        public int Semester { get; set; }
        public Boolean Enabled { get; set; }
        public String[][] CalendarS { get; set; }
    }


    
}