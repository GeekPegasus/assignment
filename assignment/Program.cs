using System;
using System.Collections.Generic;

namespace assignment
{
    class Countries{ 
        public
    }
    class Program
    {
        static void Main(string[] args){
            
            
            Dictionary<int, Countries> aDictionary = new Dictionary<int, Countries>();
            aDictionary.Add(1, new Countries() {Key = "Austria", Population = 16});

            foreach(KeyValuePair<int, Countries> c in aDictionary){
                Console.WriteLine($"{c.Key} : {c.Population}");
            }
        }
    }
}
