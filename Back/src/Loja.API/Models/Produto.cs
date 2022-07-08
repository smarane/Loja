namespace Loja.API.Models
{
    public class Produto
    {
        public int IdProduto { get; set; }

        public string NmProduto { get; set; }

        public int IdMaterial { get; set; }

        public int IdCorMaterial { get; set; }

        public string DescricaoProduto { get; set; }

        public int QtdProduto { get; set; }

        public string LocalArquivoProduto { get; set; }

        public decimal VlCustoProduto { get; set; }

        public decimal VlVendaProduto { get; set; }

    }
}