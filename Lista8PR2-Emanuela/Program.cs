using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista8PR2_Emanuela
{
    internal class Program
    {
        public static void Exercicio1() {
            Console.WriteLine("Aqui será codificado o exercício 1");
        } 
        public static void Exercicio2() {
            Console.WriteLine("Aqui será codificado o exercício 2");
        } 
        public static void Exercicio3() {
            Console.WriteLine("Aqui será codificado o exercício 3");
        } 
        public static void Exercicio4() {
            Console.WriteLine("Aqui será codificado o exercício 4");
        }
        public static void Exercicio5() {
            Console.WriteLine("Aqui será codificado o exercício 5");
        } 
        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.WriteLine("====================================");
                Console.WriteLine("     Para Sair - digite 0           ");
                Console.WriteLine("Para executar exercício 1 - digite 1");
                Console.WriteLine("Para executar exercício 2 - digite 2");
                Console.WriteLine("Para executar exercício 3 - digite 3");
                Console.WriteLine("Para executar exercício 4 - digite 4");
                Console.WriteLine("Para executar exercício 5 - digite 5");
                Console.WriteLine("====================================");

                opcao = int.Parse(Console.ReadLine()); //lê a opção escolhida 

                switch (opcao)
                {
                    case 0: Console.WriteLine("Obrigada, tchau!");
                        break;

                    case 1:
                        Exercicio1 ();
                        break; 
                    
                    case 2:
                        Exercicio2 ();
                        break;
                    
                    case 3:
                        Exercicio3 ();
                        break;
                    
                    case 4:
                        Exercicio4 ();
                        break;
                    
                    case 5:
                        Exercicio5 ();
                        break;

                        default: Console.WriteLine("Opção Inválida");
                        break;
                }

            }while(opcao != 0);
        }
    }
}
