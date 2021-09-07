using System;
using System.Collections.Generic;
using System.Text;

namespace _07092021_001.Modeles
{
   public class Station
    {
        #region attributs
        public static List<Station> collStation = new List<Station>();
        private List<Borne> collClass;
        private int idStation;
        private string libelleEmplacement;
        #endregion

        #region getter/setter
        public int IdStattion { get => idStation; set => idStation = value; }
        public string LibelleEmplacement { get => libelleEmplacement; set => libelleEmplacement = value; }
        public List<Borne> CollClass { get => collClass; set => collClass = value; }
        #endregion

        #region constructeur
        public Station(int lidStation, string lelibelleEmplacement)
        {
            idStation = lidStation;
            libelleEmplacement = lelibelleEmplacement;
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
            return  ;
        }
        #endregion
    }
}
