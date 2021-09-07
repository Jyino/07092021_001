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
        private List<Borne> _collBorne = new List<Borne>();
        public static List<Visite> CollClass = new List<Visite>();
        #endregion

        #region getter/setter
        public string Etat { get => etat; set => etat = value; }
        public int DureeTotale { get => dureeTotale; set => dureeTotale = value; }
        public Station LaStation { get => laStation; set => laStation = value; }
        public List<Borne> CollBorne { get => _collBorne; set => _collBorne = value; }
        #endregion

        #region constructeur
        public Visite(Station la_Station, List<Borne> lesBornes)
        {
            this.etat = "p";
            this.dureeTotale = 0;
            this.laStation = la_Station;
            this._collBorne = lesBornes;
            CollClass.Add(this);
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
