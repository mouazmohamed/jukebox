using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TP_JukeBox
{
    class CD : Document
    {
        private string artiste;
        private int nbPiste;

        public CD(string titre, int duree, bool enStock, string commentaire, string artiste, int nbPiste):base(titre,duree,enStock,commentaire)
        {
            this.artiste = artiste;
            this.nbPiste = nbPiste;
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine("Artiste : {0}",this.artiste);
            Console.WriteLine("Nombre de Piste : {0}",this.nbPiste);
            Console.WriteLine();
        }
    }
}