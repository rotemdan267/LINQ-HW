using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_HW
{
    public enum Definition
    {
        city,
        town
    }
    internal class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfPopulation { get; set; }

        public City(int id, string name, int numberOfPopulation)
        {
            Id = id;
            Name = name;
            NumberOfPopulation = numberOfPopulation;
        }
    }
}
