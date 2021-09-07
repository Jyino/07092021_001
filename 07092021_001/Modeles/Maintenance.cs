using System;
using System.Collections.Generic;
using System.Text;

namespace _07092021_001.Modeles
{
    public class Maintenance
    {
        #region attributs
        private List<Station> _collStation;
        private List<Technicien> _collTechnicien;
        private List<Visite> _collVisite;
        public static List<Maintenance> CollClass = new List<Maintenance>();
        #endregion

        #region getter/setter
        public List<Station> CollStation { get => _collStation; set => _collStation = value; }
        public List<Technicien> CollTechnicien { get => _collTechnicien; set => _collTechnicien = value; }
        public List<Visite> CollVisite { get => _collVisite; set => _collVisite = value; }
        #endregion

        #region constructeur
        public Maintenance(List<Technicien> lesTechniciens, List<Station> lesStations, List<Visite> lesVisites)
        {
            _collTechnicien = lesTechniciens;
            _collStation = lesStations;
            _collVisite = lesVisites;
           CollClass.Add(this);
        }
        #endregion

        #region methodes
        #endregion
    }
}
