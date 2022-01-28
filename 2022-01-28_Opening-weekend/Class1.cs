using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_01_28_Opening_weekend
{
    class Film
    {
        public string eredeticim { get; set; }
        public string magyarcim { get; set; }
        public string bemutato { get; set; }
        public string forgalmazo { get; set; }
        public int bevel { get; set; }
        public int latogato { get; set; }

        public Film(string sor)
        {
            string[] t = sor.Split(';');
            eredeticim = t[0];
            magyarcim = t[1];
            bemutato = t[2];
            forgalmazo =[3];
            bevel = int.Parse(t[4]);
            latogato = int.Parse(t[5]);
        }
    }
}
