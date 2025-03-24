using RestSharp;
using System.Text.Json;
using PokeGochi.Pokemon;

namespace PokeGochi.Menu.CreatePokemon
{
    internal class ApiRequest
    {
        public static Pokemon.PokemonObject GetPokemon(string pokemonName)
        {
            var client = new RestClient($"https://pokeapi.co/api/v2/pokemon-species/{pokemonName}/");
            RestRequest request = new RestRequest("", Method.Get);
            var response = client.Execute(request);

            var content = response.Content;

            Pokemon.PokemonObject newPokemon = JsonSerializer.Deserialize<Pokemon.PokemonObject>(content);

            return newPokemon;
        }
    }
}
