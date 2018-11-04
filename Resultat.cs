using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controle10_10
{
    class Resultat
    {
        int tempsRealise;
        Participant unParticipant;
        Epreuve uneEpreuve;


        public Resultat(Participant unParticipant, Epreuve uneEpreuve, int tempsRealise)
        {
            this.unParticipant = unParticipant;
            this.uneEpreuve = uneEpreuve;
            this.tempsRealise = tempsRealise;

        }
        public int TempsRealise
        {
            get { return tempsRealise; }
            
        }
        public Epreuve UneEpreuve
        {
            get { return uneEpreuve; }
            
        }
    }
}
