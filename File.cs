using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneFile
{
    class File : FileAstratto
    {
        private long dimensione;
        public File(Directory directory, string nome) : base(directory, nome) { }

        public override long GetDimensione()
        {
            return dimensione;
        }
        public void SetDimensione(long d)
        {
            this.dimensione = d;
        }
        public override string Stampa(string tab)
        {
            return $"{base.Stampa(tab)} ({dimensione} MB)";
        }


    }
}
