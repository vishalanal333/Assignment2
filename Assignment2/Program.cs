using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Assignment2
{
    public class Sample
    {
        public string name { get; set; }
        public int age{ get; set; }
        
    }

    public class Program
    {
        public static void Main()
        {

            string fileName = "sample.json";
            string jsonString = File.ReadAllText(fileName);
            List<Sample> sample = JsonSerializer.Deserialize<List<Sample>>(jsonString);
            
            foreach (Sample sam in sample.OrderBy(p => p.age))
            {
                if (sam.age >= 18)
                {
                    Console.WriteLine($"name: {sam.name}");
                    Console.WriteLine($"age: {sam.age}");
                }
            }

        }
    }
}


