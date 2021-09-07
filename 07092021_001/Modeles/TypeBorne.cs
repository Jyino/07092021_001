using System;
using System.Collections.Generic;
using System.Text;

namespace _07092021_001.Modeles
{
    public class TypeBorne
    {
        #region attributs
        private int dureeRevision;
        private string codeTypeBorne;
        private int nbJoursEntreRevisions;
        private int nbUnitesEntreRevisions;
        public List<TypeBorne> collClass = new List<TypeBorne>();

        #endregion

        #region getter/setter
        public int DureeRevision { get => dureeRevision; set => dureeRevision = value; }
        public string CodeTypeBorne { get => codeTypeBorne; set => codeTypeBorne = value; }
        public int NbJoursEntreRevisions { get => nbJoursEntreRevisions; set => nbJoursEntreRevisions = value; }
        public int NbUnitesEntreRevisions { get => nbUnitesEntreRevisions; set => nbUnitesEntreRevisions = value; }
        #endregion

        #region constructeur
        public TypeBorne(int ladureeRevision, string lecodeTypeBorne)
        {
            dureeRevision = ladureeRevision;
            codeTypeBorne = lecodeTypeBorne;
            collClass.Add(this);
        }
        #endregion

        #region methodes
        
        public int getDureeRevision()
        {
            return this.dureeRevision;
        }
        public int getNbJoursEntreRevisions()
        {
            return this.nbUnitesEntreRevisions;
        }
        #endregion
    }
}
