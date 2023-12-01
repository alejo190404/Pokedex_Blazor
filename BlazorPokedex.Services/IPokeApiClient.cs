using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorPokedex.Models;

namespace BlazorPokedex.Services
{
    public interface IPokeApiClient
    {
        Task<Result> GetAllPokemons(PaginationParameters parameters);
        Task<Pokemon> GetPokemon(string name);
    }
}
