using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*bjetivo: Praticar operadores relacionais e lógicos.

Tarefas:
int idade = 20;
bool temCNH = true;
bool temCarro = false;
double saldo = 150.00;

// TODO: Crie expressões booleanas para verificar:
// 1. É maior de idade (>= 18)
// 2. Pode dirigir (maior de idade E tem CNH)
// 3. Pode viajar de carro (pode dirigir E tem carro)
// 4. Pode comprar produto de R$ 100 (saldo >= 100)
// 5. Situação crítica (menor de idade OU sem CNH)

// TODO: Exiba cada verificação com resultado*/

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
           int idade = 20;
           bool temCnh = true;
           bool temCarro = false;
           double saldo = 150.00;

           bool maiordeIdade = idade >=18;
           bool podeDirigir = maiordeIdade && temCnh;
           bool viajar = podeDirigir && temCarro;
           bool podeComprar = saldo >= 100;
           bool critica = idade < 18 || !temCnh;

           Console.WriteLine("=====Verificação=====");
           Console.WriteLine("=====================");
           Console.WriteLine($"É maior de idade: {maiordeIdade}");
           Console.WriteLine($"Pode dirigir: {podeDirigir}");
           Console.WriteLine($"Pode viajar de carro proprio: {viajar}");
           Console.WriteLine($"Pode comprar produto (R$ 100): {podeComprar}");
           Console.WriteLine($"Situação critica: {critica}");
        }
    }
}
