using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorPokedex.Models
{
    public class Result
    {
        [JsonProperty("results")]
        public List<Pokemon> Pokemons { get; set; }
    }
}
