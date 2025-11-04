using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*string frase = "  Aprendendo C# é Muito Legal!  ";

// TODO: Execute e exiba:
// 1. Tamanho da string original
// 2. String em maiúsculas
// 3. String em minúsculas
// 4. String sem espaços nas extremidades
// 5. Substitua "Legal" por "Divertido"
// 6. Verifique se contém a palavra "C#"
// 7. Extraia apenas "Aprendendo C#"*/

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = " Aprendendo c# é muito  legal! ";
            string semEspaco = frase.Trim();
            string substituida = frase.Replace("Legal", "Divertido");
            string extraida = semEspaco.Substring(0 , 13);

            Console.WriteLine($"A frase original é: {frase}");
            Console.WriteLine($"O tamanho original da frase é: {frase.Length}");
            Console.WriteLine($"Maiuscula: {frase.ToUpper()}");
            Console.WriteLine($"Minuscula: {frase.ToLower()}");
            Console.WriteLine($"Sem espaço nas extremidades: {semEspaco}");
            Console.WriteLine($"Substituida: {substituida}");
            Console.WriteLine($"Contem 'c#'? {frase.Contains("c#")}");
            Console.WriteLine($"Extraida: {extraida}");



            
        }
    }
}
