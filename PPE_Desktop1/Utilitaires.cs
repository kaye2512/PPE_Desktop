using System;
using System.Collections.Generic;
namespace PPE_Desktop1
{
    public static class Utilitaires
    {

        public static List<Visiteur> CollectionVille(List<Visiteur> contacts, string Laville)
        {
            List<Visiteur> LesClientsdelaVille = new List<Visiteur>();
            foreach (Visiteur UnContact in contacts)
            {
                if (UnContact.visiteurville == Laville)
                    LesClientsdelaVille.Add(UnContact);
            }
            return LesClientsdelaVille;
        }

        public static int PossedeClients(List<Visiteur> contacts, string Laville)
        {
            List<Visiteur> LesClientsdelaVille = new List<Visiteur>();
            LesClientsdelaVille = CollectionVille(contacts,Laville);
            return LesClientsdelaVille.Count;
        }
    }
}
