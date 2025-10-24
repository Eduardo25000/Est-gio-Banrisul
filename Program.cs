using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio1
{
    class Program
    {
        static void Main ()
        {
            while(true)
            {
                menu();
                
                string opcaousuario = Console.ReadLine();
                if (opcaousuario == "1"){
                    Cliente.Criarcliente();
                    Cliente.CriarConta2();
                    
    
                }else if (opcaousuario == "2"){

                    Banco.saldo();
                   
                }else if(opcaousuario == "3")
                {
                    Cliente.Listar_clientes();

                }else
                {

                }

            }
        }

        static void menu()
        {
          
            
            Console.WriteLine("****Bem Vindo ao Banrisul****");
            Console.WriteLine("1 - Vira cliente");
            Console.WriteLine("2 - Entrar na sua conta");
            Console.WriteLine("3 - Mostrar todos os clientes");
            Console.WriteLine("4 - Sair");
            Console.WriteLine("Selecione a sua opção: ");
           

        }
    }

    class Cliente
    { 
        //atributo é o que ela necessita
        static Dictionary<string, string> nomes = new Dictionary<string, string>();
        static Dictionary<string, int> contas = new Dictionary<string, int>();

        
        static int tipo = 0;
        static int NumeroConta = 5000;

        //metodo é o que ela faz
        public static void Criarcliente()
        {    
            Console.WriteLine("Informe o seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe o seu cpf: ");
            string cpf = Console.ReadLine();           
            nomes.Add(cpf, nome);
        }

        public static void CriarConta2()
        {


            Console.WriteLine("Informe o seu cpf para criação da sua conta: ");
            string cpf = Console.ReadLine();
            contas.Add(cpf, NumeroConta);

            Console.WriteLine("Informe o tipo de conta desejavel (1- conta corrente ou 2- poupança)");
            tipo = int.Parse(Console.ReadLine());

            if (tipo == 1)
            {
                Console.WriteLine("Voce escolheu a conta corrente.");
            }
            else
            {
                Console.WriteLine("Voce escolheu a conta poupança.");
            }
            NumeroConta++;

            Console.WriteLine($"Seu numero da conta é:{NumeroConta} ");


        }

        public static void Listar_clientes()
        {
           
            
            List<string> listaDeNomes = new List<string>(nomes.Values);
            List<string>listacpf = new List<string>(nomes.Keys);

            for (int i = 0; i < listaDeNomes.Count; i++)
            {   
                Console.WriteLine($"Cliente ja existentes: {listaDeNomes[i]} do cpf: {listacpf[i]} ");
            }
        }






    }

    class Banco
    {

        static double deposito = 0;
        static double saque = 0;
        static double transferencia = 0;
        public static double saldo1 = 0;
        static string cpf;

        public static void saldo()
        {


            Console.WriteLine("Informe o seu cpf: ");
            cpf = Console.ReadLine();

            saldo1 = saldo1 - saque;
            saldo1 = saldo1 + deposito;
            saldo1 = saldo1 - transferencia;

            if (saldo1 >= 0)
            {
                Console.WriteLine($"Seu saldo disponivel é: {saldo1}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }

        }

        


    }

}   

