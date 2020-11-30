using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneFile
{
    public abstract class FileAstratto
    {
        public string Nome { get; private set; }

        public Directory Padre { get; private set; }

        public FileAstratto(Directory directory, string nome)
        {
            Nome = nome;
            Padre = directory;

        }
        public abstract long GetDimensione();
        

        public virtual string Stampa(string tab)
        {
            return Nome;
        }


    }
}
