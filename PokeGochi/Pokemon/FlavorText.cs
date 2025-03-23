using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeGochi.Pokemon
{
    internal class FlavorText
    {
        [JsonPropertyName("flavor_text")]
        public string text {  get; set; }
    }
}
