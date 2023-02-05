using System.Collections.Generic;

namespace Generic
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var eating = new Eating<Apple>();
            
            var p = new Product<int>("Яблоко", 100, 100);
            var p2 = new Product<int>("Банан", 100, 100);

            var list = new List<int>();
            var map = new Dictionary<int, string>();
            map.Add(5, "пять");
            map.Add(6, "шесть");
        }
    }
}