using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controle10_10
{
    class Tri
    {
        string nature;
        Epreuve natation;
        Epreuve velo;
        Epreuve course;
        List<Participant> lesParticipants;

        Tri(string nature, int distanceNatation, int distanceVelo, int distanceCourse)
        {
            this.nature = nature;
            this.natation = new Epreuve("natation", distanceNatation);
            this.velo = new Epreuve("velo", distanceVelo);
            this.course = new Epreuve("course", distanceCourse);

        }

        public void AddParticipant(Participant unParticipant)
        {
            lesParticipants.Add(unParticipant);
        }
        public Epreuve GetEpreuve(string nom)
        {
            switch (nom)
            {
                case "natation":
                    return this.natation;
                case "velo":
                    return this.velo;
                case "course":
                    return this.course;
                default:
                    return null;
            }

        }
        public Participant getParticipantById(int id)
        {
            for (int i = 0; i < lesParticipants.Count; i++)
            {
                if (lesParticipants[i].Id == id)
                    return lesParticipants[i];
            }
            return null;
            
        }

        public string Nature
        {
            get { return this.nature; }
        }



    }
}
