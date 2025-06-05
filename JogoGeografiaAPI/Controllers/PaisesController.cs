using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace JogoGeografiaAPI.Controllers
{
    [Route("api/pais]")]
    [ApiController]
    public class PaisesController : ControllerBase
    {
        private static readonly List<Pais> paises = new()
        {
            new Pais { Id = 1, NomePais = "Brasil", CapitalPais = "Brasília", Continente = "América do Sul" },
            new Pais { Id = 2, NomePais = "Alemanha", CapitalPais = "Berlim", Continente = "Europa" },
            new Pais { Id = 3, NomePais = "Japão", CapitalPais = "Tokyo", Continente = "Ásia" },
            new Pais { Id = 4, NomePais = "Egito", CapitalPais = "Cairo", Continente = "África" },
            new Pais { Id = 5, NomePais = "Austrália", CapitalPais = "Camberra", Continente = "Oceania" }
        };

        [HttpGet]
        public IEnumerable<Pais> Get()
        {
            return paises;
        }
    }

}
