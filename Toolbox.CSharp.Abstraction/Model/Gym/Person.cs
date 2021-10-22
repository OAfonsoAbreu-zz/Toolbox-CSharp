using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox.CSharp.Abstraction.Model.Gym
{
    public class Person
    {
        /// <summary>
        /// For a Gym, information about person`s name, height and weight
        /// are most important
        /// </summary>
        /// <param name="name"></param>
        /// <param name="height"></param>
        /// <param name="weight"></param>
        public Person(string name, double height, double weight)
        {
            Name = name;
            Height = height;
            Weight = weight;
            BMI = weight / Math.Pow(height,2);
        }
        public string Name { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public double BMI { get; }
    }
}
