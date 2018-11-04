using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controle10_10
{
    class Participant
    {
        DateTime dateInscription;
        int id;
        string nom;
        List<Resultat> lesResultats;

        public Participant(string nom, DateTime dateInscription)
        {
            this.dateInscription = dateInscription;
            this.nom = nom;
            lesResultats = new List<Resultat>();

        }
        public string Nom
        {
            get { return nom; }
        }
        public void Add(Epreuve uneEpreuve,int tempsRealise)
        {
            if (this.ResultatPresent(uneEpreuve)==false)
            {
                this.lesResultats.Add(new Resultat(this,uneEpreuve,tempsRealise));
            }
        }
        public DateTime DateInscription
        {
            get
            {
                return this.dateInscription;
            }
        }
        public int Id
        {
            get { return this.id; }
        }
        public int TempsTotal()
        {
            int tps=0;
            for (int i = 0; i < lesResultats.Count; i++)
            {
                tps = tps + lesResultats[i].TempsRealise; 
            }
            return tps;
        }
        public bool HorsDelai()
        {
            for (int i = 0; i < lesResultats.Count; i++)
            {
                if (lesResultats[i].TempsRealise > lesResultats[i].UneEpreuve.TempsEliminatoire)
                    return true;
            }
            return false;
        }
        public bool ResultatPresent(Epreuve uneEpreuve)
        {
            for (int i = 0; i < lesResultats.Count; i++)
            {
                if (lesResultats[i].UneEpreuve.Nom==uneEpreuve.Nom){
                    return true;
                }
            }
            return false;
        }
        
    }
}
