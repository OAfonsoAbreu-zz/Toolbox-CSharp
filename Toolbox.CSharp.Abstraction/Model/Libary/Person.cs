using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox.CSharp.Abstraction.Model.Libary
{
    public class Person
    {
        /// <summary>
        /// For a library, information about person`s name, birth date, address 
        /// and phone are most important
        /// </summary>
        /// <param name="name"></param>
        /// <param name="birthDate"></param>
        /// <param name="address"></param>
        /// <param name="phone"></param>
        public Person(string name, DateTime birthDate, Address address, string phone)
        {
            Name = name;
            BirthDate = birthDate;
            Phone = phone;
            Address = address;
            Age = DateTime.Now.Month >= birthDate.Month 
                ? DateTime.Now.Year - birthDate.Year 
                : DateTime.Now.AddYears(-1).Year - birthDate.Year ;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        public Address Address { get; set; }
        public string Phone { get; set; }
    }
}
