using System;
using System.Collections.Generic;
using System.Text;

namespace _07092021_001.Modeles
{
    class Visite
    {
        #region attributs

        private string etat;
        private int dureeTotale;
        private Station laStation;
        private List<Borne> _collClass = new List<Borne>();
        #endregion

        #region getter/setter
        public string Etat { get => etat; set => etat = value; }
        public int DureeTotale { get => dureeTotale; set => dureeTotale = value; }
        public Station LaStation { get => laStation; set => laStation = value; }
        public List<Borne> CollClass { get => _collClass; set => _collClass = value; }
        #endregion

        #region constructeur
        public Visite(string letat, int ladureeTotale, Station la_Station)
        {
            etat = letat;
            dureeTotale = ladureeTotale;
            laStation = la_Station;
            //  _collClass.Add(this);
        }
        #endregion

        #region methodes
        public void changerEtat()
        {
            .etat;
        }
        #endregion
    }
}
