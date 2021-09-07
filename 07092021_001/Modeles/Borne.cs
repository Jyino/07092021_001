using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _07092021_001.Modeles
{
   public class Borne
    {
        #region attributs
        private int idBorne;
        private DateTime dateDerniereRevision;
        private int _indiceCompteurUnites;
        private TypeBorne type;
        public static List<Borne> CollClass = new List<Borne>();
        #endregion

        #region getter/setter
        public int IdBorne { get => idBorne; set => idBorne = value; }
        public DateTime DateDerniereRevision { get => dateDerniereRevision; set => dateDerniereRevision = value; }
        public int IndiceCompteurUnites { get => _indiceCompteurUnites; set => _indiceCompteurUnites = value; }
        public TypeBorne Type { get => type; set => type = value; }


        #endregion

        #region constructeur
        public Borne(int lidBorne, DateTime ladateDerniereRevision, int lindiceCompteurUnites, TypeBorne letype)
        {
            CollClass.Add(this);
            this.idBorne = lidBorne;
            dateDerniereRevision = ladateDerniereRevision;
            _indiceCompteurUnites = lindiceCompteurUnites;
            this.type = letype;
        }
        #endregion


        #region methodes
        public int get500()
        {
            foreach (Borne uneBorne in Borne.CollClass)
            {
                if (uneBorne.IdBorne == 500)
                {
                    return uneBorne.IdBorne;
                }
            }
            return 0;
        }
        public int getDureeRevision()
        {
            return this.Type.getDureeRevision();
        }

        public bool estAReviser()
        {
            if ((this._indiceCompteurUnites > Type.getNbUnitesEntreRevisions()) || (int)(DateTime.Now - this.DateDerniereRevision.TotalDays > this.Type.getNbJoursEntreRevisions))
            {
                return true;

            }
            return false;
        }
       
        #endregion
    }
}
