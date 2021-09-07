using System;
using System.Collections.Generic;
using System.Text;

namespace _07092021_001.Modeles
{
    class Maintenance
    {
        #region attributs
        private List<Station> collStation;
        private List<Technicien> collTechnicien;
        private List<Visite> collVisite;
        public static List<Maintenance> collMaintenance = new List<Maintenance>();
        #endregion

        #region getter/setter
        public List<Station> CollStation { get => collStation; set => collStation = value; }
        public List<Technicien> CollTechnicien { get => collTechnicien; set => collTechnicien = value; }
        public List<Visite> CollVisite { get => collVisite; set => collVisite = value; }
        #endregion

        #region constructeur
        public Maintenance()
        {
            collStation = Station.CollStation
            Maintenance.collMaintenance.Add(this);
        }
        #endregion

        #region methodes
        #endregion
    }
}
