using System;

namespace Generic
{
    public class Product<T>
    {
        public string Name { get; set; }
        public T Volume { get; set; }
        public T Energy { get; set; }

        public Product(string name, T volume, T energy)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
            Volume = volume;
            Energy = energy;
        }
    }
}