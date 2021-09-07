using System;
using System.Collections.Generic;
using System.Text;

namespace _07092021_001.Modeles
{
   public class Station
    {
        #region attributs
        public static List<Station> CollClass = new List<Station>();
        private List<Borne> collBorne;
        private int _idStation;
        private string _libelleEmplacement;
        #endregion

        #region getter/setter
        public int IdStattion { get => _idStation; set => _idStation = value; }
        public string LibelleEmplacement { get => _libelleEmplacement; set => _libelleEmplacement = value; }
        public List<Borne> LesBornes { get => collBorne; set => collBorne = value; }
        #endregion

        #region constructeur
        public Station(int lidStation, string lelibelleEmplacement)
        {
            _idStation = lidStation;
            _libelleEmplacement = lelibelleEmplacement;
            this.LesBornes = new List<Borne>();
            CollClass.Add(this);
        }
        #endregion

        #region methodes
        public int getId()
        {
            return this.idStation;
        }

        public string getLibelleEmplacement()
        {
            return this.libelleEmplacement;
        }

        public Visite getVisiteAFaire()
        {
            
            foreach(Visite visite in Visite.collVisite)
            {
                
            }
            return Visite
        }
        #endregion
    }
}
