using PokeGochi.Pokemon;
using PokeGochi.Controller.SaveManagement;
using PokeGochi.View;
using PokeGochi.Controller.CreatePokemon;

namespace PokeGochi.Controller
{
    internal class GameManager
    {
        public void Play()
        {
            PokemonObject pokemon = VerifyArchive.ReadSave();

            GameLoopMenu gameLoopMenu = new GameLoopMenu();

            if (pokemon == null)
            {
                gameLoopMenu.AdotarPet();
                pokemon = CreatePokemonMenu.EscolherPokemon();

                VerifyArchive.WriteSave(pokemon);
            }

            while (true)
            {
                Console.Clear();
                Console.WriteLine(pokemon.ToString());
                Console.ReadLine();
            }
        }
    }
}
