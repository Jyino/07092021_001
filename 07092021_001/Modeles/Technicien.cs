using System;
using System.Collections.Generic;
using System.Text;

namespace _07092021_001.Modeles
{
    class Technicien
    {
        #region attributs
        
        private int matricule;
        private string nom;
        private string prenom;
        private List<Visite> collClass;
        #endregion

        #region getter/setter
        public int Matricule { get => matricule; set => matricule = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public List<Visite> CollClass { get => collClass; set => collClass = value; }
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
        #endregion
    }
}
