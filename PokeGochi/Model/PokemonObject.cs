using System.Text.Json.Serialization;

namespace PokeGochi.Pokemon
{
    internal class PokemonObject
    {
        [JsonPropertyName("name")] public string Name { get; set; }
        [JsonPropertyName("id")] public int Id { get; set; }
        [JsonPropertyName("flavor_text_entries")]public List<FlavorText> Flavor_Text {  get; set; }
        public string Owner {  get; set; }

        public string flavorText => Flavor_Text[0].text
                .Replace('\f', ' ')
                .Replace('\u00ad', ' ')
                .Replace('\n', ' ');

        public PokemonObject() { }

        public PokemonObject(string owner, string name, int id, List<FlavorText> flavor_Text)
        {
            Owner = owner;
            Name = name;
            Id = id;
            Flavor_Text = flavor_Text;
        }

        public override string ToString()
        {
            return $"Dono: {Owner}.\n" +
                $"Nome: {Name}.\n" +
                $"Id: {Id}.\n" +
                $"Descrição: {flavorText}.";
        }
    }
}
