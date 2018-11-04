using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controle10_10
{
    class Epreuve
    {
        int distance;
        string nom;
        int tempsEliminatoire;

        public Epreuve(string nom, int distance)
        {
            this.nom = nom;
            this.distance = distance;
        }
        public int Distance
        {
            get { return distance; }
        }
        public string Nom
        {
            get { return nom; }
        }
        public int SetTempsEliminatoire
        {
            get { return tempsEliminatoire; }
            set { this.tempsEliminatoire = value; }
        }
        public int TempsEliminatoire
        {
            get { return tempsEliminatoire; }
        }
        
    }
}
