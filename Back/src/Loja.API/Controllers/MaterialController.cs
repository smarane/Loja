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

    public class MaterialController : ControllerBase
    {
        public IEnumerable<Material> _material = new Material[]
            {
                new Material
                {
                    IdMaterial = 1,
                    NmMaterial = "PLA"
                },
                new Material
                {
                    IdMaterial = 2,
                    NmMaterial = "PETG"
                },
                new Material
                {
                    IdMaterial = 3,
                    NmMaterial = "ABS"
                }
            };
         
    
        [HttpGet]
        public IEnumerable<Material> Get()
        {
            return _material;
        }

        [HttpGet("IdMaterial")]
        public IEnumerable<Material> GetByIdMaterial( int IdMaterial){
            return _material.Where( material => material.IdMaterial == IdMaterial );
        }
    } 
}