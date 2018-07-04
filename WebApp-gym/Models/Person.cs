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

        public Person(string name, string lastname)
        {
            Name = name;
            Lastname = lastname;
        }

        public string Name { get; set; }
        public string Lastname { get; set; }
        
    }


    
}