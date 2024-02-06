using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_JukeBox
{
    class Program
    {
        static void Main()
        {
            DataBase db = new DataBase();
            Video V = new Video("Apprendre les bases du C# en 60s", 1, false, "Vidéo YouTube", "Graven");
            CD uncD = new CD("Billie Jean", 5, true, "Musique connue faisant partie de l'album Thriller", "Michael Jackson", 7);
            db.AddDocument(V);
            db.AddDocument(uncD);
            db.Editer();
            Console.ReadLine();
        }
    }
}
