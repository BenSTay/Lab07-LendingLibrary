using System;
using System.Collections.Generic;
using System.Text;

namespace LendingLibrary.Classes
{
    public class Author
    {
        public string Name { get; set; } 
        public string HomeCountry { get; set; }
        public DateTime DateOfBirth { get; set;  }

        public Author(string name, string homeCountry, int birthYear, int birthMonth, int birthDay)
        {
            Name = name;
            HomeCountry = homeCountry;
            DateOfBirth = new DateTime(birthYear, birthMonth, birthDay);
        }
    }
}
