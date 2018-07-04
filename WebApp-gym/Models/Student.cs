using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp_gym.Models
{
    public class Student
    {
        public String Name { get; set; }
        public String Lastname { get; set; }
        public int CodeS { get; set; }
        public String Career { get; set; }
        public Boolean Enabled { get; set; }
        public String[][] CalendarS { get; set; }
    }
}