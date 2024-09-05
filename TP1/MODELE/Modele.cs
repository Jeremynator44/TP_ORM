using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1.Entities;

namespace TP1.MODELE
{
    public static class Modele
    {
        private static LoubeyreJeremyBdPartitionsContext monModel;
        public static void init()
        {
            monModel = new LoubeyreJeremyBdPartitionsContext();
        }
        public static List<Client> listeClients()
        {
            return monModel.Clients.ToList();
        }
        public static List<Commande> listeCommandes()
        {
            return monModel.Commandes.Include(a => a.NumcliNavigation).ToList();
        }
        public static List<Commande> listeCommandesParClient(int idClient)
        {
            List<Commande> lesCommandes = monModel.Commandes.Where(p => p.Numcli ==
           idClient).Include(p => p.NumcliNavigation).ToList();
            return lesCommandes;
        }

    }
}
 