using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_JukeBox
{
    public class DataBase
    {
        private ArrayList documents;
        public DataBase()
        {
            documents = new ArrayList();
        }
        public void AddDocument(Document d)
        {
            documents.Add(d);
        }
        public void Editer()
        {
            foreach (Document d in documents)
            {
                d.Afficher();
            }

            /*
            for (int i = 0; i<documents.Count; i++)
            {
                if(documents[i] is CD)
                {
                    CD c = (CD)documents[i];
                    c.Afficher();
                }
                else
                {
                    Video v = (Video)documents[i];
                    v.Afficher();
                }
            }
            */
        }
    }
}
