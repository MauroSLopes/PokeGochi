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

            // Garante a leitura do arquivo, caso não existente retorna nulo.
            // Garante a criação de um novo pokemon em caso de arquivo corrompido ou modificado de forma errada.

            Mascot pokemon = VerifyArchive.ReadSave();

            GameLoopMenu gameLoopMenu = new GameLoopMenu();

            if (pokemon == null)
            {
                pokemon = CreatePokemonMenu.EscolherPokemon();

                VerifyArchive.WriteSave(pokemon);
            }

            while (true)
            {
                // Protege contra opções invalidas, evita crashs na aplicação devido a inputs errados.
                try { 
                int opcao = gameLoopMenu.MenuInteracao();

                switch (opcao) {
                        case 1: 
                            pokemon.BrincarPokemon(); break;
                        case 2: 
                            pokemon.AlimentarPokemon(); break;
                        case 3:
                            pokemon.ConversarPokemon(); break;
                        case 4:
                            pokemon.VerificarPokemon(); break;
                        case 5:
                            gameLoopMenu.GoodByeMensage();
                            VerifyArchive.WriteSave(pokemon);
                            return; break;
                        default:
                            Console.WriteLine("Opção invalida."); break;
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
