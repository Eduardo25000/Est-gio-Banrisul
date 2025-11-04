using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Objetivo: Praticar declaração de variáveis e operadores aritméticos.

Tarefas:
Crie um programa que:

Declare duas variáveis numéricas com valores à sua escolha
Execute e exiba todas as operações básicas:
Soma
Subtração
Multiplicação
Divisão
Resto da divisão (módulo)*/

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorA = 10;
            double valorB = 5;
            double soma =0;
            double subtracao = 0;
            double multiplicacao = 0;
            double divisao =0;

            soma = valorA + valorB;
            subtracao = valorA - valorB;
            multiplicacao = valorA * valorB;
            divisao = valorA / valorB;

            Console.WriteLine($"O primeiro valor é: {valorA} E o segundo valor é: {valorB}");
            Console.WriteLine($"A soma dos valores é: {soma}");
            Console.WriteLine($"A subtração dos valores é: {subtracao}");
            Console.WriteLine($"A multiplicação dos valores é: {multiplicacao}");
            Console.WriteLine($"A divisão dos valores é: {divisao}");



        }
    }
}
