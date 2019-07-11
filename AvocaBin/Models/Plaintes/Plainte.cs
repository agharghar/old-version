using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AvocaBin.Models.Plaintes
{
    class Plainte
    {
        private String idPlainte;

        public String IdPlainte
        {
            get { return idPlainte; }
            set { idPlainte = value; }
        }
        private DateTime dateCreation;
        private DateTime dateDepotPlainte;

        public DateTime DateDepotPlainte
        {
            get { return dateDepotPlainte; }
            set { dateDepotPlainte = value; }
        }

        public DateTime DateCreation
        {
            get { return dateCreation; }
            set { dateCreation = value; }
        }
        
        private String signePlainte;

        public String SignePlainte
        {
            get { return signePlainte; }
            set { signePlainte = value; }
        }
        private int idPlaignant;

        public int IdPlaignant
        {
            get { return idPlaignant; }
            set { idPlaignant = value; }
        }
        private String ville;

        public String Ville
        {
            get { return ville; }
            set { ville = value; }
        }
        private String typeTribunal;

        public String TypeTribunal
        {
            get { return typeTribunal; }
            set { typeTribunal = value; }
        }

        public String typePlaint;
        public String TypePlaint
        {
            get { return typePlaint; }
            set { typePlaint = value; }
        }

        public Plainte()
        {
        }



    }
}
