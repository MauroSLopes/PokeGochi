using PokeGochi.Menu;
using PokeGochi.Controller.CreatePokemon;

namespace PokeGochi.View
{
    internal class GameLoopMenu : MenuBase
    {

        public int MenuInteracao()
        {
            WelcomeMensage();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Brincar");
            Console.WriteLine("2 - Comer");
            Console.WriteLine("3 - Convesar");
            Console.WriteLine("4 - Observar");
            Console.WriteLine("5 - Sair");
            return int.Parse(Console.ReadLine());
        }
    }
}
