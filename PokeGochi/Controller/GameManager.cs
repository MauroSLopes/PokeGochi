using PokeGochi.Pokemon;
using PokeGochi.Controller.SaveManagement;
using PokeGochi.View;
using PokeGochi.Controller.CreatePokemon;
using PokeGochi.Model;

namespace PokeGochi.Controller
{
    internal class GameManager
    {
        public void Play()
        {
            Mascot pokemon = VerifyArchive.ReadSave();

            GameLoopMenu gameLoopMenu = new GameLoopMenu();

            if (pokemon == null)
            {
                pokemon = CreatePokemonMenu.EscolherPokemon();

                VerifyArchive.WriteSave(pokemon);
            }

            while (true)
            {
                try { 
                int opcao = int.Parse(gameLoopMenu.MenuInteracao());

                switch (opcao) {
                    case 1: pokemon.BrincarPokemon(); break;
                    case 2: pokemon.AlimentarPokemon(); break;
                    case 3: pokemon.VerificarPokemon(); break;
                    case 4:
                        gameLoopMenu.GoodByeMensage();
                        return; 
                    break;
                    default:
                        Console.WriteLine("Opção invalida.");
                    break;
                }

                Console.ReadLine();
                }
                catch
                {
                    continue;
                }
            }
        }
    }
}
