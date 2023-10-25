using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bolygok
{
    internal class naprendszer
    {
        public string nev {  get; set; }
        public int holdszam { get; set; }
        public double arany {  get; set; }

        public naprendszer(string sor)
        {
            string[] x = sor.Split(';');
            nev = x[0];
            holdszam = int.Parse(x[1]);
            arany = double.Parse(x[2].Replace('.', ','));
        }
    }
}
