using System;
using System.Collections.Generic;
using System.Text;

namespace _07092021_001.Modeles
{
    public class Technicien
    {
        #region attributs
        
        private int matricule;
        private string nom;
        private string prenom;
        private List<Visite> _collVisite;
        public static List<Technicien> CollClass = new List<Technicien>();
        #endregion

        #region getter/setter
        public int Matricule { get => matricule; set => matricule = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public List<Visite> CollVisite { get => _collVisite; set => _collVisite = value; }
        #endregion

        #region constructeur
        public Technicien(int lematricule, string lenom, string leprenom)
        {
            matricule = lematricule;
            nom = lenom;
            prenom = leprenom;
           
        }
        #endregion

        #region methodes
        public int getTempsOccupe()
        {
            int result = 0;
            foreach(Visite laVisite in this._collVisite)
            {
                result += laVisite.getDureeTotal();
            }
            return result;
        }
        public void affecterVisite(Visite uneVisite)
        {
            uneVisite.changerEtat();
            this._collVisite.Add(uneVisite);
            
        }
        public List<Visite> getLesVisites()
        {
            return this._collVisite;
        }
        #endregion
    }
}
