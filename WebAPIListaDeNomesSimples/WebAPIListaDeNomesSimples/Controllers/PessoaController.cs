using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIListaDeNomesSimples.Models;

namespace WebAPIListaDeNomesSimples.Controllers
{
    public class PessoaController : ApiController
    {
        List<Pessoa> Pessoas = new List<Pessoa>()
        {
            new Pessoa(){Nome = "Irineu",Idade = 25 },
            new Pessoa(){Nome = "Josep",Idade = 98 },
            new Pessoa(){Nome = "Giomar",Idade = 41 },
            new Pessoa(){Nome = "Adornildo",Idade = 65 },
            new Pessoa(){Nome = "Farizeu",Idade = 45 },
            new Pessoa(){Nome = "Rusberto",Idade = 87 },
            new Pessoa(){Nome = "Dopanildo",Idade = 26 },
            new Pessoa(){Nome = "Buscopan",Idade = 42 },
            new Pessoa(){Nome = "Buscatrigo",Idade = 46 },
            new Pessoa(){Nome = "Trasagua",Idade = 14 },
        };

        public List<Pessoa> Get()
        {
            return Pessoas;
        }

        public Pessoa Post(Pessoa item)
        {
            Pessoas.Add(item);

            return item;
        }

    }
}
