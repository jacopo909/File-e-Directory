using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneFile
{
     public class Directory : FileAstratto
     {

        private List<FileAstratto> Figli = new List<FileAstratto>();
        public Directory(Directory directory, string nome) : base(directory, nome) { }


        
        public void Addfile(FileAstratto f)
        {
            Figli.Add(f);
        }
        public override long GetDimensione()
        {
            long dimensione = 0;
            foreach (FileAstratto f in Figli)
            {
                dimensione += f.GetDimensione();
            }
            return dimensione;
        }
        public override string Stampa(string tab)
        {
            string s = base.Stampa(tab);
            foreach (FileAstratto f in Figli)
            {
                s += "\n" + f.Stampa(tab + "--");
            }
            return s;
        }

     }
        
    
}
