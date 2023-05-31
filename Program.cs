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
            var sorok = File.ReadAllLines("felfedezesek.csv").Skip(1);
            foreach (var sor in sorok)
            {
                var mezok = sor.Split(';');
                Kemia uj = new Kemia(mezok[0],mezok[1],mezok[2],int.Parse(mezok[3]),mezok[4]);
                KemiaList.Add(uj);
            }



            //3.feladat
            Console.WriteLine($"3.feladat: Elemek száma: {KemiaList.Count()}");


            //4.feladat
            Console.WriteLine($"4.feladat: Felfedezések száma az ókorban: {KemiaList.Where(x => x.Ev == "Ókor").Count()}");

            //5.feladat
            bool helyes = false;
            do
            {
                Console.WriteLine("Kérek egy vegjelet: ");
                string vegyjele = Console.ReadLine();

                if (vegyjele.Length > 2)
                {
                    helyes = false;
                }
                else { helyes = true; };

            } while (helyes == false);

            string HelyesVegyjel = "Sg";
            //6.feladat


            if (KemiaList.Any(x => x.Vegyjel.ToLower() == HelyesVegyjel.ToLower()) == true)
            {
                KemiaList.Where(x => x.Vegyjel.ToLower() == HelyesVegyjel.ToLower()).ToList().ForEach(x => Console.WriteLine($"\t Az elem vegyjele: {x.Vegyjel} " +
                    $"\tAz elem neve: {x.Nev} " +
                    $"\tRendszáma: {x.Rendszam} " +
                    $"\tFelfedezés éve:{x.Ev} " +
                    $"\tFelfedező{x.FelfedNev}"));
            }
            else
            {
                Console.WriteLine("Nincs ilyen elem az adatforásban");
            }


            //7.feladat
            int leghosszabb=0;
            foreach (var item in KemiaList)
            {
                leghosszabb = int.Parse( KemiaList[1].Ev) - int.Parse( KemiaList[0].Ev);
                int index = 0;
                if (int.Parse( KemiaList[index+1].Ev)- int.Parse( KemiaList[index].Ev)>leghosszabb)
                {
                    leghosszabb = (int.Parse(KemiaList[index + 1].Ev) - int.Parse(KemiaList[index].Ev));
                    index++;
                }
            }
            Console.WriteLine($"7.feladat: {leghosszabb} volt a leghosszabb időszak két elem felfedezése között.");

            //8.feladat
            Console.WriteLine("8.feladat: Statisztika");
            foreach (var item in KemiaList)
            {
                if (item.Ev != "Ókor")
                {

                }
            }
        }
    }
}
