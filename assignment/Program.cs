using System;
using System.Collections.Generic;

namespace assignment
{
    class Program
    {
        static void Main(string[] args){
            List<Country> countries = new List<Country>();
            countries.Add(new Country("Austria", 1.98));        
                }
    }

    internal class Country
    {
        public Country(string name, double population)
        {
            Name = name;
            Population = population;
        }
        public string Name { get; set; }
        public double Population { get; set; }
    }
}
