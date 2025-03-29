using PokeGochi.Menu;
using PokeGochi.Controller.CreatePokemon;

namespace PokeGochi.View
{
    internal class GameLoopMenu : MenuBase
    {
        public void AdotarPet()
        {
            WelcomeMensage();
            Console.WriteLine("Pronto para escolher seu primeiro pokemon?");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Opções:");
        }

        public string MenuInteracao()
        {
            WelcomeMensage();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Brincar");
            Console.WriteLine("2 - Comer");
            Console.WriteLine("3 - Observar");
            Console.WriteLine("4 - Sair");
            return Console.ReadLine();
        }
    }
}
