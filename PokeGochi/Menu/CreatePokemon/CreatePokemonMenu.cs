using PokeGochi.Pokemon;
using PokeGochi.Menu.CreatePokemon;

namespace PokeGochi.Menu.CreatePokemon
{
    internal class CreatePokemonMenu : MenuBase
    {
        Dictionary<string, string> availablePokemons = new Dictionary<string, string>() {
            { "1", "Charmander" }, { "2", "Bulbasaur"}, {"3", "Squirtle"},
            { "4", "Arceus" }, {"5", "Rhyperior"}, {"6", "Lugia"},
            { "7", "Torchic"}, {"8", "Koraidon"}, { "9", "Riolu"}
        };

        public Pokemon.Pokemon EscolherPokemon()
        {
            while (true)
            {
                WelcomeMensage();

                for (int i = 1; i <= availablePokemons.Count; i++)
                {
                    Console.WriteLine($"{i} - {availablePokemons[i.ToString()]}");
                }

                Console.Write("Digite o indice do pokemon que deseja: ");
                string opcao = Console.ReadLine();

                if (!availablePokemons.ContainsKey(opcao)) Console.WriteLine("Opção não encontrada, favor escolher outra.");
                else
                {
                    Console.Clear();
                    Pokemon.Pokemon newPokemon = ApiRequest.GetPokemon(availablePokemons[opcao]);
                    Console.WriteLine(newPokemon.ToString());
                    Console.WriteLine("----------------");
                    Console.WriteLine($"Deseja adotar o {newPokemon.Name}?\n S - Sim. N - Não");
                    string resposta = Console.ReadLine();

                    switch (resposta.ToLower())
                    {
                        case "s":
                            Console.WriteLine("Parabéns por encontrar seu parceiro de aventuras! Espero que vocês dois se divirtam muito juntos!");
                            return newPokemon;
                            break;
                        case "n":
                            continue;
                            break;
                    }
                }
            }
        }

        public override void WelcomeMensage()
        {
            base.WelcomeMensage();
            Console.WriteLine("Pronto para escolher seu primeiro pokemon?");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Opções:");
        }
    }
}
