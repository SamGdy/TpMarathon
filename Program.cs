using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controle10_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Epreuve e1 = new Epreuve("natation", 200);
            Epreuve e2 = new Epreuve("velo", 100);
            Epreuve e3 = new Epreuve("course", 42);
            e1.SetTempsEliminatoire = 50;
            e2.SetTempsEliminatoire=50;
            e3.SetTempsEliminatoire = 50;
            DateTime date=new DateTime(1999,02,20);
            Participant p = new Participant("s", date);
            p.Add(e1, 45);
            p.Add(e2, 45);
            p.Add(e3, 45);
            Console.WriteLine(p.HorsDelai());
            Console.WriteLine("tps totaux = {0}",p.TempsTotal());
            Console.ReadLine();
        }
    }
}
