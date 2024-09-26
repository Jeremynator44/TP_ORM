using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TP1.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

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
        public static List<Entities.Commande> listeCommandes()
        {
            return monModel.Commandes.Include(a => a.NumcliNavigation).ToList();
        }
        public static List<Partition> listePartitions()
        {
            return monModel.Partitions.ToList();
        }
        public static List<Style> listeStyle()
        {
            return monModel.Styles.ToList();
        }

        public static List<Entities.Commande> listeCommandesParClient(int idClient)
        {
            List<Entities.Commande> lesCommandes = monModel.Commandes.Where(p => p.Numcli ==
           idClient).Include(p => p.NumcliNavigation).ToList();
            return lesCommandes;
        }

        public static List<Entities.Commande> listeCommandesParMontant(int Montant)
        {
            List<Entities.Commande> lesCommandes = monModel.Commandes.Where(p => p.Montantcde >=
           Montant).Include(p => p.NumcliNavigation).ToList();
            return lesCommandes;
        }

        public static List<Partition> listePartitionParStyle(int Style)
        {
            List<Partition> lesPartitionsStyle = monModel.Partitions.Where(p => p.Numstyle ==
           Style).Include(p => p.NumstyleNavigation).ToList();
            return lesPartitionsStyle;
        }

        public static bool AjoutCommande(int montant, DateTime dateC, int idClient)
        {
            Commande maCommande;
            bool vretour = true;
            try
            {
                maCommande = new Commande();
                maCommande.Montantcde = montant; // mise à jour des propriétés
                maCommande.Datecde = dateC.Date; // la propriété DateCde doit être
                //en DateTime dans la BD et dans la classe Commande, modifier si besoin.
                maCommande.Numcli = idClient;
                // ajout de l’objet : correspond à un insert
                monModel.Commandes.Add(maCommande);
                monModel.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
            }
            return vretour;
        }
        //Pour convertir dateTime en dateOnly :var en Date = DateOnly.FromDateTime(variable en dateTime);
        //Pour convertir date en dateTime :var en DateTime = ((DateOnly)(variable en date)).ToDateTime(TimeOnly.parse("00:00"));


        public static Commande RecupererCommande(int idCommande)
        {
            Commande uneCommande = new Commande();
            try
            {
                uneCommande = monModel.Commandes.Include(c => c.Numparts).First(x =>
               x.Numcde == idCommande);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return uneCommande;
        }

        public static bool ModifCommande(int idCde, int montant, DateTime dateC, int idClient)
        {
            Commande maCommande;
            bool vretour = true;
            try
            {
                maCommande = RecupererCommande(idCde);
                maCommande.Montantcde = montant; // mise à jour des propriétés
                maCommande.Datecde = dateC.Date; // la propriété DateCde doit être
                //en DateTime dans la BD et dans la classe Commande, modifier si besoin.
                maCommande.Numcli = idClient;
                // ajout de l’objet : correspond à un insert
                monModel.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
            }
            return vretour;
        }

        public static bool SuppCommande(int idCommande)
        {
            bool vretour = true;
            try
            {
                Commande maCommande = RecupererCommande(idCommande);
                monModel.Commandes.Remove(maCommande); // correspond au DELETE
                monModel.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                vretour = false;
            }
            return vretour;
        }



    }
}
 