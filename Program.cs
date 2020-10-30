using System;
using System.Globalization;
using System.Net;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace Exercício_Construtores_Leo_A._Demicio
{
    public class Program
    {
        static void Main(string[] args)
        {
            // criação de um novo objeto.
            Produto p = new Produto();

            // declaração das variáveis do objeto, incluindo nome, preço e quantidade.
            Console.WriteLine("Entre com os dados do produto: "); 
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            // exibição dos dados referentes a declaração das variáveis.
            Console.WriteLine("Dados do produto: " + p);

            // adição de X produtos ao estoque.
            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qte);
            
            // exibição dos dadeos atualizados.
            Console.WriteLine("Dados atualizados: " + p);

            // remoção de X produtos do estoque.
            Console.WriteLine("Digite o número de produtos a serem removidos do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProduto(qte);

            // exibição final dos dados.
            Console.WriteLine("Dados atualizados: " + p);

            Console.ReadKey();
        }
    }
}

         
