using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo2020
{
    public class CompareTest
    {
        
    }

    public class Car: IComparable<Car>
    {
        public string Company { get; set; }
        public int Rating { get; set; }

        static Random rand = new Random();

        public Car(string comp)
        {
            this.Company = comp;
            this.Rating = rand.Next(10,100);
        }

        public int CompareTo(Car t)
        {
            return Rating.CompareTo(t.Rating);
        }
    }

    public class GClass<T> where T : class, IComparable<T>
    {
        public string Company { get; set; }
        public int Rating { get; set; }

        static Random rand = new Random();

        public GClass(string comp)
        {
            this.Company = comp;
            this.Rating = rand.Next();
        }
            
        public int CompareTo(GClass<T> t)
        {
            return Company.CompareTo(t.Company);
        }
    }
}
