using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class ListDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product (){Name = "Pen", Price = 100},
            new Product (){Name = "Ferrari", Price = 1000000},
            new Product (){Name = "Mansion", Price = 7000000}
        };
        public List<Product> LoadData()
        {
            Console.WriteLine("I'm reading List data.");
            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("I've saved data for my List database.");
        }
    }
}
