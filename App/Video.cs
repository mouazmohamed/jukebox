using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_JukeBox
{
    class Video : Document
    {
        private string metteurEnScene;

        public Video(string titre, int duree, bool enStock, string commentaire, string metteurEnScene):base(titre, duree, enStock, commentaire)
        {
            this.metteurEnScene = metteurEnScene;
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine("Metteur en Scène : {0}",this.metteurEnScene);
            Console.WriteLine();
        }
    }
}
