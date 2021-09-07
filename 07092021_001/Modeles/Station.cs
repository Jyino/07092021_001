using System;
using System.Collections.Generic;
using System.Text;

namespace _07092021_001.Modeles
{
    public class Station
    {
        #region attributs
        public static List<Station> CollClass = new List<Station>();
        private List<Borne> _collBorne;
        private int _idStation;
        private string _libelleEmplacement;
        #endregion

        #region getter/setter
        public int IdStattion { get => _idStation; set => _idStation = value; }
        public string LibelleEmplacement { get => _libelleEmplacement; set => _libelleEmplacement = value; }
        public List<Borne> CollBorne { get => _collBorne; set => _collBorne = value; }
        #endregion

        #region constructeur
        public Station(int lidStation, string lelibelleEmplacement)
        {
            _idStation = lidStation;
            _libelleEmplacement = lelibelleEmplacement;
            this._collBorne = new List<Borne>();
            CollClass.Add(this);
        }
        #endregion

        #region methodes
        /// <summary>
        /// 01 - Recuperer l'id de la session courante
        /// </summary>
        /// <returns>l'Id de la station</returns>
        public int getId()
        {
            return this._idStation;
        }

        public string getLibelleEmplacement()
        {
            return this._libelleEmplacement;
        }

        public Visite getVisiteAFaire()
        {
            Visite v = null;
            foreach (Visite visite in Visite.CollClass)
            {

            }
            return v;
        }
        #endregion
    }
}
