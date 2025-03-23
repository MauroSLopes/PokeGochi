using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeGochi.Menu
{
    internal class MenuBase
    {
        public virtual void WelcomeMensage()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo ao PokeCenter!");
        }

        public void GoodByeMensage()
        {
            Console.Clear();
            Console.WriteLine("Espero te ver em breve!");
        }

    }
}
