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
    public class ProdutoController : ControllerBase
    {
        public IEnumerable<Produto> _produto = new Produto[]{
            new Produto
            {
                IdProduto = 1,
                NmProduto = "Caixa",
                IdMaterial = 1,
                IdCorMaterial = 1,
                DescricaoProduto = "",
                QtdProduto = 3,
                LocalArquivoProduto = "",
                VlCustoProduto = 100,
                VlVendaProduto = 300
            },
            new Produto
            {
                IdProduto = 2,
                NmProduto = "Ponte Japonesa",
                IdMaterial = 1,
                IdCorMaterial = 1,
                DescricaoProduto = "",
                QtdProduto = 3,
                LocalArquivoProduto = "",
                VlCustoProduto = 200,
                VlVendaProduto = 500
            },
            new Produto
            {
                IdProduto = 3,
                NmProduto = "Arco Japonês",
                IdMaterial = 1,
                IdCorMaterial = 1,
                DescricaoProduto = "",
                QtdProduto = 5,
                LocalArquivoProduto = "",
                VlCustoProduto = 50,
                VlVendaProduto = 250
            }
        };
        
        [HttpGet]
        public IEnumerable<Produto> Get()
        {
           return _produto;
          
        }
        [HttpGet("IdProduto")]
        public IEnumerable<Produto> GetByIdProduto(int IdProduto){
            return _produto.Where( produto => produto.IdProduto == IdProduto );
        }
    }    
}
