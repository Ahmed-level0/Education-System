using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDU_System
{
    public class Person
    {
        public string Name;
        public int id;
        public string userName;
        public string Password;
        public Person(string Name, int id, string userName, string Password){
        this.Name = Name;
        this.userName = userName;
        this.Password = Password;
        this.id = id;
        }
    }
}