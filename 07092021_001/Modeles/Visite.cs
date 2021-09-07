using System;
using System.Collections.Generic;
using System.Text;

namespace _07092021_001.Modeles
{
     public class Visite
    {
        #region attributs

        private string _etat;
        private int _dureeTotale;
        private Station _laStation;
        private List<Borne> _collBorne = new List<Borne>();
        public static List<Visite> CollClass = new List<Visite>();
        #endregion

        #region getter/setter
        public string Etat { get => _etat; set => _etat = value; }
        public int DureeTotale { get => _dureeTotale; set => _dureeTotale = value; }
        public Station LaStation { get => _laStation; set => _laStation = value; }
        public List<Borne> CollBorne { get => _collBorne; set => _collBorne = value; }
        #endregion

        #region constructeur
        public Visite(Station la_Station, List<Borne> lesBornes)
        {
            this._etat = "p";
            this._dureeTotale = 0;
            this._laStation = la_Station;
            this._collBorne = lesBornes;
            CollClass.Add(this);
        }
        #endregion

        #region methodes
       public int getDureeTotale()
        {
            return this._dureeTotale;
        }

        public string getEtat()
        {

        }
        #endregion
    }
}
