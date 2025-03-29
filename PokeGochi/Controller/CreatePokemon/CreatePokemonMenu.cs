using PokeGochi.Pokemon;
using PokeGochi.Menu;
using PokeGochi.Model;

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

        public static Mascot EscolherPokemon()
        {
            string ownerName = IdentifyOwner();

            Console.Clear();

            Console.WriteLine("Que belo nome!");
            Thread.Sleep(1000);
            Console.Clear();
            return CreatePokemon(ownerName);

            
        }

        private static string IdentifyOwner()
        {
            while (true)
            {

                new MenuBase().WelcomeMensage();

                Console.WriteLine("Está pronto para viver grandes aventuras com seu novo pokemon?");
                Console.Write("Primeiro preciso saber, qual o seu nome?: ");
                string owner = Console.ReadLine();

                Console.WriteLine($"{owner}, está certo?\nS - Sim. N - Não");
                string rp = Console.ReadLine();

                switch (rp.ToLower()[0])
                {
                    case 's':
                        return owner;
                        break;
                    case 'n':
                        continue;
                        break;
                    default: Console.WriteLine("Opção não encontrada"); break;
                }

                Console.Clear();
            }
        }

        private static Mascot CreatePokemon(string ownerName)
        {
            while (true)
            {
                Console.WriteLine("Vamos escolher agora o seu pokemon? Aqui na minha mesa eu tenho as seguintes opções: ");
                // Mostra todas as opções de pokemons.
                // Feito desse jeito para que o menu seja expansivo.

                for (int i = 1; i <= availablePokemons.Count; i++)
                {
                    Console.WriteLine($"{i} - {availablePokemons[i.ToString()]}");
                }

                Console.Write("Para escolher, apenas digite o numero correspondente ao pokemon: ");
                string opcao = Console.ReadLine();

                // Verifica se a opção existe.
                // Serve para impedir que saia do escopo dos pokemons ou que o usuario faça input de uma informação errada.

                if (!availablePokemons.ContainsKey(opcao))
                {
                    Console.Clear();
                    Console.WriteLine("Opção não encontrada, favor escolher outra.");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
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
                            Console.Write($"Que tal dar um apelido para o seu {newPokemon.Name}? digite o nome dele: ");
                            string? nickName = Console.ReadLine();
                            return new Mascot(new PokemonObject(newPokemon.Name, newPokemon.Id, newPokemon.Flavor_Text), ownerName, nickName);
                            break;
                        case 'n':
                            Console.Clear();
                            continue;
                            break;
                        default: Console.WriteLine("Opção não encontrada"); break;
                    }
                }
            }
        }
    }
}
