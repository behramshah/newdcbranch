using System;
using System.Collections.Generic;

namespace example_dictionary
{
    class Program
    {
        public static Dictionary<int, object> countries = new Dictionary<int, object>();
        static void Main(string[] args)
        {

            DictionaryAdd();      
                 
            
            
        }
        static object CreateO()
        {
            Console.WriteLine("Insert Country Name");
            string Name=Console.ReadLine();
            Country GOV = new Country(Name);
            return GOV;
        }
        static void DictionaryAdd()
        {

            Console.WriteLine("Insert the key of value you add");
            int counter = Convert.ToInt32(Console.ReadLine());
            countries.Add(counter, CreateO());
            foreach (Country g in countries.Values)
            {
                Console.WriteLine(g.GetInfo());
            }
            counter = counter + 1;

            Console.WriteLine("Insert the key of value you need to remove");
            counter = Convert.ToInt32(Console.ReadLine());
            countries.Remove(counter);

            void DictionaryRemove()
            {
                Console.WriteLine("Insert the key of value you need to remove");
                int counter = Convert.ToInt32(Console.ReadLine());
                countries.Remove(counter);
            }

        }



    }
    public class Country
    {
        public string name { get; set; }
        public Country (string n) { name = n;}


        public string GetInfo()
        {
            Console.WriteLine($"Country: {name}");
            return name;
        }

    }
}
