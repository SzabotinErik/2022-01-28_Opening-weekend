using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2022_01_28_Opening_weekend
{
    class Openingweekend
    {
        static void Main(string[] args)
        {
            List<Film> filmek = new List<Film>();
            foreach (var sor in File.ReadAllLines("nyitohetvege.txt").Skip(1))
            {
                filmek.Add(new Film(sor));
            }
            Console.WriteLine($"3.feladat: filmek száma: {filmek.Count} db");
            
            int osszeg;
            foreach (var i in filmek)
	        {
                if (i.forgalmazo == "UIP" && i.bemutato == "2016.12.01")
	            {
                    osszeg=osszeg+i.bevel;
	            }
                if else(i.forgalmazo == "UIP" && i.bemutato == "2016.12.02")
	            {
                    osszeg=osszeg+i.bevel;
	            }
                if else(i.forgalmazo == "UIP" && i.bemutato == "2016.12.03")
	            {
                    osszeg=osszeg+i.bevel;
	            }
                if else(i.forgalmazo == "UIP" && i.bemutato == "2016.12.04")
	            {
                    osszeg=osszeg+i.bevel;
	            }
                if else(i.forgalmazo == "UIP" && i.bemutato == "2016.12.05")
	            {
                    osszeg=osszeg+i.bevel;
	            }
                if else(i.forgalmazo == "UIP" && i.bemutato == "2016.12.06")
	            {
                    osszeg=osszeg+i.bevel;
	            }
                if else(i.forgalmazo == "UIP" && i.bemutato == "2016.12.07")
	            {
                    osszeg=osszeg+i.bevel;
	            }
	        }
            Console.WriteLine($"4.feladat:UIP Duna Film forgalmazó bevetele{osszeg} ");

            Console.ReadKey();
        }
    }
}
