using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Simule uma compra com 3 produtos:

// Produto 1
string nomeProduto1 = "Mouse Gamer";
decimal precoProduto1 = 89.90m;
int quantidadeProduto1 = 2;

// TODO: Crie variáveis para mais 2 produtos

// TODO: Calcule:
// - Subtotal de cada produto
// - Total da compra
// - Desconto de 10% se total > 200
// - Total final

// TODO: Exiba um recibo formatado*/


namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
          string nomeProduto1 = "Mouse Gamer";
          decimal precoProduto1 = 89.90m;
          int quantidade = 2;
          decimal subTOTAL1 =0;
            
          string nomeProduto2 = "Teclado Gamer";
          decimal precoProduto2 = 250;
          int quantidade2 = 1;
          decimal subTotal2 =0;

          string nomeProduto3 = "MousePad";
          decimal precoProduto3 = 30.50m;
          int quantidade3 = 1;
          decimal subTotal3 = 0;

          decimal  Total =0; 
          decimal desconto =0;
          decimal valorFinal =0;

          subTOTAL1 = quantidade * precoProduto1;
          subTotal2 = quantidade2 * precoProduto2;
          subTotal3 = quantidade3 * precoProduto3;

          Total = subTOTAL1 + subTotal2 + subTotal3;             
            
          Console.WriteLine($"Mause Gamer a Quantidade é: {quantidade} E o valor da soma dele é: {subTOTAL1}");
          Console.WriteLine($"Teclado Gamer a Quantidade é: {quantidade2} E o valor da soma dele é: {subTotal2}");
          Console.WriteLine($"MousePad a Quantidade é: {quantidade3} E o valor da soma dele é: {subTotal3}");

          Console.WriteLine($"Valor original da compra foi de: {Total}");
          
          if (Total > 200)
            {
                desconto = Total * 0.10m;
            }



          Console.WriteLine($"valor do desconto é: {desconto}");

          valorFinal = Total - desconto;

          Console.WriteLine($"O valor final ficou de: {valorFinal}");
        }
    }
}
