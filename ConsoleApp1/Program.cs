using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{



    class Program
    {
        static void Main(string[] args)
        {
            var motoList = FillData();

            //SelectAndFilter(motoList);
            //SingleAndFirst(motoList);
            //Sorting(motoList);
            //Aggregation(motoList);
            TakeSkip(motoList);
            Console.ReadLine();

        }




        private static void SelectAndFilter(List<Motorcycle> motoList)
        {
            Console.WriteLine("low prices");
            Console.WriteLine();
            var lowPrice = motoList.Where(moto => moto.Price < 2000);
            foreach (var motorcycle in lowPrice)
            {
                motorcycle.Report();
            }
            Console.WriteLine();
            Console.WriteLine("names only");
            Console.WriteLine();
            var allNames = motoList.Select(x => x.Name);
            foreach (var motorcycle in allNames)
            {
                Console.WriteLine(motorcycle);
            }

            Console.WriteLine();
            Console.WriteLine("names And Prices");
            Console.WriteLine();

            //anonymous class 
            foreach (var motorcycle in motoList.Select(x=>new {Name=x.Name, Price=x.Price}))
            {
                Console.WriteLine($"{motorcycle.Name} costs {motorcycle.Price}$");
            }
        }

        private static void SingleAndFirst(List<Motorcycle> motoList)
        {
            motoList.First().Report();

            var moto = motoList.FirstOrDefault(x => x.Make == "Aprillia"); //this sets value to null
            if(moto!=null) moto.Report();

            // moto = motoList.First(x => x.Make == "Aprillia"); //this one throws exception

            moto = motoList.SingleOrDefault(x => x.Make == "Aprillia");
            //moto = motoList.Single(x => x.Make == "Aprillia"); //this one throws exception
            if (moto!=null) moto.Report();

            moto = motoList.SingleOrDefault(x => x.Make == "Minsk");
            if (moto != null) moto.Report();

            //moto = motoList.SingleOrDefault(x => x.Make == "Honda");//this one throws exception - more than one, even SingleOrDefault
        }

        private static void Sorting(List<Motorcycle> motoList)
        {
            var sorted = motoList.OrderBy(x => x.Price);
            foreach (var motorcycle in sorted)
            {
                motorcycle.Report();
            }

            sorted = motoList.OrderBy(x => x.Make).ThenByDescending(x => x.Price);
            Console.WriteLine("now 2 sorts");
            foreach (var motorcycle in sorted)
            {
                motorcycle.Report();
            }
        }

        private static void Aggregation(List<Motorcycle> motoList)
        {
            var aggregate = motoList.Select(x => x.Name).Aggregate((x, y) => x + "," + y);
            Console.WriteLine(aggregate);
            Console.WriteLine(motoList.Sum(x=>x.Price));
            Console.WriteLine(motoList.Where(x=>x.Year>2000).Min(x=>x.Price));
        }

        private static void TakeSkip(List<Motorcycle> motoList)
        {
            var secondPage=motoList.OrderBy(x => x.Price).Skip(3).Take(3);//taking or skipping more than we have will return empty
            foreach (var motorcycle in secondPage)
            {
                motorcycle.Report();
            }
        }

        private static List<Motorcycle> FillData()
        {
            return new List<Motorcycle>()
            {
                new Motorcycle(){Make = "Honda", Name = "Transalp", Year = 1991, Price = 1800},
                new Motorcycle(){Make = "Honda", Name = "Gold Wing", Year = 1995, Price = 4000},
                new Motorcycle(){Make = "Suzuki", Name = "Bandit", Year = 1999, Price = 2700},
                new Motorcycle(){Make = "Minsk", Name = "XC250", Year = 2019, Price = 1300},
                new Motorcycle(){Make = "Minsk", Name = "D4", Year = 2019, Price = 900},
                new Motorcycle(){Make = "BMW", Name = "R 1200 GS", Year = 2018, Price = 22000},
                new Motorcycle(){Make = "Yamaha", Name = "R1", Year = 2009, Price = 8000},

            };
        }


    }

    public class Motorcycle
    {
        public string Name { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        public void Report()
        {
            Console.WriteLine($"{Make} {Name} made in {Year} is {Price}$ worth");
        }
    }
}
