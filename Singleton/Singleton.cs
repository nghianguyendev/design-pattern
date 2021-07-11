using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public interface IDatabase
    {
        int GetPopulation(string name);
    }

    public class SingletonDatabase : IDatabase
    {
        private Dictionary<string, int> capitals;

        private static int instanceCount;
        public static int Count => instanceCount;

        private SingletonDatabase()
        {
            Console.WriteLine("Initializing database");

            this.capitals = new Dictionary<string, int>
            {
                ["saigon"] = 15000000
            };

            //capitals = File.ReadAllLines(
            //  Path.Combine(
            //    new FileInfo(typeof(IDatabase).Assembly.Location).DirectoryName, "capitals.txt")
            //  )
            //  .Batch(2)
            //  .ToDictionary(
            //    list => list.ElementAt(0).Trim(),
            //    list => int.Parse(list.ElementAt(1)));
        }

        public int GetPopulation(string name)
        {
            return capitals[name];
        }

        // laziness + thread safety
        private static Lazy<SingletonDatabase> instance = new Lazy<SingletonDatabase>(() =>
        {
            instanceCount++;
            return new SingletonDatabase();
        });

        public static IDatabase Instance => instance.Value;
    }
}
