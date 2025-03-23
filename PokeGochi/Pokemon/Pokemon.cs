using System.Text.Json.Serialization;

namespace PokeGochi.Pokemon
{
    internal class Pokemon
    {
        [JsonPropertyName("name")] public string Name { get; set; }
        [JsonPropertyName("id")] public int Id { get; set; }
        [JsonPropertyName("flavor_text_entries")]public List<FlavorText> Flavor_Text {  get; set; }

        public override string ToString()
        {
            return $"Nome: {Name}.\n" +
                $"Id: {Id}.\n" +
                $"Descrição: {Flavor_Text[0].text
                .Replace('\f', ' ')
                .Replace('\u00ad', ' ')
                .Replace('\n', ' ')}";
        }
    }
}
