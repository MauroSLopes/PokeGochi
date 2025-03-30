using System.Text.Json.Serialization;

namespace PokeGochi.Pokemon
{
    internal class PokemonObject
    {
        // Objeto referente a desserialização da chamada na API

        [JsonPropertyName("name")] public string Name { get; set; }
        [JsonPropertyName("id")] public int Id { get; set; }
        [JsonPropertyName("flavor_text_entries")]public List<FlavorText> Flavor_Text {  get; set; }

        // Remoção de caracteres especiais. 
        public string flavorText => Flavor_Text[0].text
                .Replace('\f', ' ')
                .Replace('\u00ad', ' ')
                .Replace('\n', ' ');
        

        public PokemonObject() { }

        public PokemonObject(string name, int id, List<FlavorText> flavor_Text)
        {
            Name = name;
            Id = id;
            Flavor_Text = flavor_Text;
        }

        public override string ToString()
        {
            return $"Nome: {Name}.\n" +
                $"Id: {Id}.\n" +
                $"Descrição: {flavorText}.";
        }
    }
}
