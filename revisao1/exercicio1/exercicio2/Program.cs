using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Objetivo: Trabalhar com tipos numéricos e conversões.

Tarefas:
Crie um programa que converta temperaturas de Celsius para:

Fahrenheit: F = C * 9/5 + 32
Kelvin: K = C + 273.15*/


namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius = 25.0;
            double fahrenheit = 0;
            double kelvin =0;

            fahrenheit = (celsius * 9/5) + 32;
            kelvin = celsius + 273.15;

            Console.WriteLine($"A temperatura em Celsius é: {celsius}");
            Console.WriteLine($"A temperatura em Fahrenheit é: {fahrenheit}");
            Console.WriteLine($"A temperatura em Kelvin é: {kelvin}");
           
        }
    }
}
