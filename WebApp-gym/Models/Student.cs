using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp_gym.Models
{
    public class Student
    {
        public String name { get; set; }
        public String lastname { get; set; }
        public int code { get; set; }
        public String career { get; set; }
        public Boolean enabled { get; set; }
        public String[][] calendar { get; set; }
    }
}