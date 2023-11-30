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
        List<Pokemon> Pokemons { get; set; }
    }
}
