using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Loja.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Loja.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CorMaterialController: ControllerBase
    {
        public IEnumerable<CorMaterial> _corMaterial = new CorMaterial[] 
        {
            new CorMaterial
                {
                    IdCorMaterial = 1,
                    NmCorMaterial = "Preto",
                    IdMaterial = 1
                },
                new CorMaterial
                {
                    IdCorMaterial = 2,
                    NmCorMaterial = "Branco",
                    IdMaterial = 1
                },
                new CorMaterial
                {
                    IdCorMaterial = 3,
                    NmCorMaterial = "Azul Claro",
                    IdMaterial = 1
                },
                new CorMaterial
                {
                    IdCorMaterial = 4,
                    NmCorMaterial = "Vermelho",
                    IdMaterial = 1
                }
        };

        [HttpGet]
        public IEnumerable<CorMaterial> Get()
        {
            return _corMaterial;
        }

        [HttpGet("{IdCorMaterial}")]
        public IEnumerable<CorMaterial> GetByIdCorMaterial(int IdCorMaterial)
        {
            return _corMaterial.Where( corMaterial => corMaterial.IdCorMaterial == IdCorMaterial );
        }

    }
}