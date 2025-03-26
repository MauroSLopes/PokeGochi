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
    }
}
