using System;
using System.Collections.Generic;
using System.Text;

namespace _07092021_001.Modeles
{
    class Borne
    {
        #region attributs
        private int idBorne;
        private DateTime dateDerniereRevision;
        private int indiceCompteurUnites;
        private TypeBorne type;
        public static List<Borne> CollClass = new List<Borne>();
        #endregion

        #region getter/setter
        public int IdBorne { get => idBorne; set => idBorne = value; }
        public DateTime DateDerniereRevision { get => dateDerniereRevision; set => dateDerniereRevision = value; }
        public int IndiceCompteurUnites { get => indiceCompteurUnites; set => indiceCompteurUnites = value; }
        public TypeBorne Type { get => type; set => type = value; }


        #endregion

        #region constructeur
        public Borne(int lidBorne, DateTime ladateDerniereRevision, int lindiceCompteurUnites, TypeBorne letype)
        {
            CollClass.Add(this);
            idBorne = lidBorne;
            dateDerniereRevision = ladateDerniereRevision;
            indiceCompteurUnites = lindiceCompteurUnites;
            this.type = letype;
        }
        #endregion

        #region methodes
        #endregion
    }
}
