using BlazorPokedex.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorPokedex.Services
{
    public class PokeApiClient : IPokeApiClient
    {
        private readonly HttpClient _httpClient;
        public PokeApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<Result> GetAllPokemons(PaginationParameters parameters)
        {

            return JsonConvert.DeserializeObject<Result>(
                await _httpClient.GetStringAsync($"pokemon?limit={parameters.PageSize}&offset={parameters.Offset}"));

        }

        public Task<IEnumerable<Pokemon>> GetAllPokemons()
        {
            throw new NotImplementedException();
        }

        public async Task<Pokemon> GetPokemon(string name)
        {
            return JsonConvert.DeserializeObject<Pokemon>(await _httpClient.GetStringAsync($"pokemon/{name}"));
        }
    }
}
