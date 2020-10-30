using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exercício_Construtores_Leo_A._Demicio
{
    

    public class Produto
    {
        // declaração das variáveis.
        public string Nome;
        public double Preco;
        public int Quantidade;
        private int quantidade;

        // criação dos métodos do programa.
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProduto(int qte)
        {
            Quantidade = Quantidade - qte;
        }
        public override string ToString()
        {
            return Nome
            + ", R$: "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ","
            +  Quantidade
            + "unidades, Total: R$ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
