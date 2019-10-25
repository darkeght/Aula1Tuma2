using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CalculandoIdade.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CalculoIdadeController : ApiController
    {
        /// <summary>
        /// Retorna nome da aplicação eo que ela faz
        /// </summary>
        /// <returns>Retorna o que nosso app faz</returns>
        public string Get()
        {
            return "App para poder beber hoje";
        }

        public string Get(int anoNascimento,string nomeUsuario = "Defaul")
        {
            if((DateTime.Now.Year - anoNascimento) >= 18)
            {
                return   $"Olá {nomeUsuario} De acordo com os calculos realizados em nosso servidor"
                       + "o sistema identifica que você poderar desfrutar de "
                       + "recursos hidricos alcoolicos";
            }
            else
            {
                return $" Olá {nomeUsuario} Felizmente as fazendas em nosso territorio ainda produzem"
                      +"leite e sucos naturais para você desfrutar";
            }
        }
    }
}
