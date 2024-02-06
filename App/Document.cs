using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_JukeBox
{
    public class Document
    {
        protected string titre;
        protected int duree;
        protected bool enStock;
        protected string commentaire;

        public Document(string titre, int duree, bool enStock, string commentaire)
        {
            this.titre = titre;
            this.duree = duree;
            this.enStock = enStock;
            this.commentaire = commentaire;
        }
        public string getCommentaire()
        {
            return this.commentaire;
        }

        public void setCommentaire(string commentaire)
        {
            this.commentaire = commentaire;
        }

        public void setEnStock(bool enStock)
        {
            this.enStock = enStock;
        }

        /*
        public void Afficher()
        {
            Console.WriteLine("Vidéo/CD : {0} ({1}mn)", this.titre, this.duree);
            if (enStock)
            {
                Console.WriteLine("Cette vidéo/Ce CD \"{0}\" est en stock.", this.titre);
            }
            else
            {
                Console.WriteLine("Cette vidéo/Ce CD \"{0}\" n\'est pas en stock.", this.titre);
            }
            Console.WriteLine(this.getCommentaire());
        }
        */

        public virtual void Afficher()
        {
            if(this.enStock==true)
            {
                Console.WriteLine("Titre : {0}",this.titre);
                Console.WriteLine("Il est bien en stock !");
                Console.WriteLine("Durée : {0}mn",this.duree);
                Console.WriteLine("Commentaire : {0}", this.commentaire);
            }
            else
            {
                Console.WriteLine("Titre : {0}", this.titre);
                Console.WriteLine("Il n\'est pas du tout en stock malheureusement !");
                Console.WriteLine("Durée : {0}mn", this.duree);
                Console.WriteLine("Commentaire : {0}", this.commentaire);
            }
        }
    }
}