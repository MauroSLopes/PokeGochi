using PokeGochi.Pokemon;
using PokeGochi.Menu;

namespace PokeGochi.Controller.CreatePokemon
{
    internal class CreatePokemonMenu
    {
        // Para adicionar mais tipos de opção basta adicionar mais entradas na lista.

        private static Dictionary<string, string> availablePokemons = new Dictionary<string, string>() {
            { "1", "Charmander" }, { "2", "Bulbasaur"}, {"3", "Squirtle"},
            { "4", "Arceus" }, {"5", "Rhyperior"}, {"6", "Lugia"},
            { "7", "Torchic"}, {"8", "Koraidon"}, { "9", "Riolu"}
        };

        public static PokemonObject EscolherPokemon()
        {
            while (true)
            {
            
                // Mostra todas as opções de pokemons.
                // Feito desse jeito para que o menu seja expansivo.

                for (int i = 1; i <= availablePokemons.Count; i++)
                {
                    Console.WriteLine($"{i} - {availablePokemons[i.ToString()]}");
                }

                Console.Write("Digite o indice do pokemon que deseja: ");
                string opcao = Console.ReadLine();

                // Verifica se a opção existe.
                // Serve para impedir que saia do escopo dos pokemons ou que o usuario faça input de uma informação errada.

                if (!availablePokemons.ContainsKey(opcao)) Console.WriteLine("Opção não encontrada, favor escolher outra.");
                else
                {
                    // Confirma a opção requisitada.

                    Console.Clear();
                    PokemonObject newPokemon = ApiRequest.GetPokemon(availablePokemons[opcao]);
                    Console.WriteLine(newPokemon.ToString());
                    Console.WriteLine("----------------");
                    Console.WriteLine($"Deseja adotar o {newPokemon.Name}?\n S - Sim. N - Não");
                    string resposta = Console.ReadLine();

                    switch (resposta.ToLower()[0])
                    {
                        case 's':
                            Console.WriteLine("Parabéns por encontrar seu parceiro de aventuras! Mas... Qual o seu nome mesmo?");
                            string ownerName = Console.ReadLine();
                            newPokemon.Owner = ownerName;
                            return newPokemon;
                            break;
                        case 'n':
                            continue;
                            break;
                        default: Console.WriteLine("Opção não encontrada"); break;
                    }
                }
            }
        }
    }
}
