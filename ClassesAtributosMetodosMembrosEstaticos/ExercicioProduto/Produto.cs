using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProduto
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;  
        }

        public void AdicionarProdutos(int quant)
        {
            Quantidade += quant;
        }

        public void RemoverProdutos(int quant)
        {
            Quantidade -= quant;
        }
    }
}
