using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NossaLigaApi.Controllers
{
    [Route("tabela")]
    public class TabelaController : ApiController
    {
        [HttpGet]
        public string Get()
        {
            return "Novas Tabelas";
        }
    }
}
