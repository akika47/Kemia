using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat05
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Kemia> KemiaList = new List<Kemia>();
            var mezok = File.ReadAllLines("felfedezesek.csv").Skip(1).ToString().Split(';');
            foreach (var item in KemiaList)
            {
                Kemia uj = new Kemia(mezok[0],mezok[1],mezok[2],int.Parse(mezok[3]),mezok[4]);
                KemiaList.Add(uj);
            }



            //3.feladat
            Console.WriteLine(KemiaList.Count());


            //4.feladat
            Console.WriteLine($"Felfedezések száma az ókorban:{KemiaList.Where(x => x.Ev.Contains("Ókor")).Count()}");

            //5.feladat
            Console.WriteLine("Kérek egy vegjelet: ");
            string vegyjele=Console.ReadLine();
            string HelyesVegyjel = "KR";
            //6.feladat


            if (KemiaList.Any(x => x.Vegyjel.ToLower() == HelyesVegyjel.ToLower()) == true)
            {
                KemiaList.Where(x => x.Vegyjel.ToLower() == HelyesVegyjel.ToLower()).Select(x=> x.Ev).ToList();
            }


        }
    }
}
