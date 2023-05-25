using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista8PR2_Emanuela
{
    internal class Program
    {
        public static void Exercicio1()
        {

            float quantp, valorp, valort = 0, quant = 0;
            int i;

            i = 1;
            do
            {
                Console.WriteLine("Digite a quantidade de itens: ");
                quantp = float.Parse(Console.ReadLine());
                if (quantp > 0)
                {
                    Console.WriteLine("Digite o preço da unidade: ");
                    valorp = float.Parse(Console.ReadLine());

                    valort += quantp * valorp;
                    quant += quantp;

                    Console.WriteLine("A quantidade de itens é: " + quant);
                    Console.WriteLine("O total é: " + valort);
                    i++;
                }
            } while (quantp > 0);
        }
        public static void Exercicio2()
        {

            string nome, nomemenor = " ", nomemaior = " ";
            int numitens, parada = 2;
            float preco, menorvalor, maiorvalor;

            menorvalor = float.MaxValue;
            maiorvalor = float.MinValue;

            do
            {
                if (parada != 1)
                {
                    Console.WriteLine("Informe o nome do produto: ");
                    nome = Console.ReadLine();

                    Console.WriteLine("Infome a quantidade: ");
                    numitens = int.Parse(Console.ReadLine());

                    Console.WriteLine("Entre com preço unitario: ");
                    preco = float.Parse(Console.ReadLine());

                    float total = numitens * preco;

                    if (total > maiorvalor)
                    {
                        maiorvalor = total;
                        nomemaior = nome;
                    }

                    if (total < menorvalor)
                    {
                        menorvalor = total;
                        nomemenor = nome;
                    }

                    Console.WriteLine("Digite 1 para SAIR ou 2 para CONTINUAR");
                    parada = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("maior quantia investida {0} no produto {1} ", +maiorvalor, nomemaior);
                Console.WriteLine("menor quantia investida {0} no produto {1} ", +menorvalor, nomemenor);

            } while (parada != 1);
        }

        public static void Exercicio3()
        {

            float peso, totalpesos = 0;
            int i;

            Console.WriteLine("Digite o total de avaliações: ");
            int avaliação = int.Parse(Console.ReadLine());

            i = 1;
            do
            {
                Console.WriteLine("Digite os pesos das notas : ");
                peso = float.Parse(Console.ReadLine());

                totalpesos = peso;

                i++;

            } while (i <= avaliação);

            if (totalpesos < 100)
                Console.WriteLine("Nota insuficiente");

            else if (totalpesos > 100)
                Console.WriteLine("Nota superior");

            else
                Console.WriteLine("Nota atingida");
        }
        public static void Exercicio4()
        {

            string estado;

            Console.WriteLine(" ==========MENU============ ");
            Console.WriteLine("AC");
            Console.WriteLine("AL");
            Console.WriteLine("AP");
            Console.WriteLine("AM");
            Console.WriteLine("BA");
            Console.WriteLine("CE");
            Console.WriteLine("DF");
            Console.WriteLine("ES");
            Console.WriteLine("GO");
            Console.WriteLine("MA");
            Console.WriteLine("MT");
            Console.WriteLine("MS");
            Console.WriteLine("MG");
            Console.WriteLine("PA");
            Console.WriteLine("PB");
            Console.WriteLine("PR");
            Console.WriteLine("PE");
            Console.WriteLine("PI");
            Console.WriteLine("RJ");
            Console.WriteLine("RN");
            Console.WriteLine("RS");
            Console.WriteLine("RO");
            Console.WriteLine("RR");
            Console.WriteLine("SC");
            Console.WriteLine("SP");
            Console.WriteLine("SE");
            Console.WriteLine("TO");
            Console.WriteLine(" ========================= ");

            Console.WriteLine("escolha a sigla de um estado ");
            estado = Console.ReadLine();

            switch (estado)
            {
                case "AC":
                    Console.WriteLine("Acre");
                    break;

                case "AL":
                    Console.WriteLine("Alagoas");
                    break;

                case "AP":
                    Console.WriteLine("Amapá");
                    break;

                case "AM":
                    Console.WriteLine("Amazonas");
                    break;

                case "BA":
                    Console.WriteLine("Bahia");
                    break;

                case "CE":
                    Console.WriteLine("Ceará");
                    break;

                case "DF":
                    Console.WriteLine("Distrito Federal");
                    break;

                case "ES":
                    Console.WriteLine(" Espírito Santo");
                    break;

                case "GO":
                    Console.WriteLine(" Goiás");
                    break;

                case "MA":
                    Console.WriteLine(" Maranhão ");
                    break;

                case "MT":
                    Console.WriteLine(" Mato Grosso");
                    break;

                case "MS":
                    Console.WriteLine("Mato Grosso do Sul  ");
                    break;

                case "MG":
                    Console.WriteLine(" Minas Gerais");
                    break;

                case "PA":
                    Console.WriteLine(" Pará");
                    break;

                case "PB":
                    Console.WriteLine(" Paraíba");
                    break;

                case "PR":
                    Console.WriteLine(" Paraná");
                    break;

                case "PE":
                    Console.WriteLine(" Pernambuco");
                    break;

                case "PI":
                    Console.WriteLine("Piauí");
                    break;

                case "RJ":
                    Console.WriteLine(" Rio de Janeiro");
                    break;

                case "RN":
                    Console.WriteLine(" Rio Grande do Norte");
                    break;

                case "RS":
                    Console.WriteLine(" Rio Grande do Sul");
                    break;

                case "RO":
                    Console.WriteLine(" Rondônia ");
                    break;

                case "RR":
                    Console.WriteLine(" Roraima");
                    break;

                case "SC":
                    Console.WriteLine(" Santa Catarina ");
                    break;

                case "SP":
                    Console.WriteLine(" São Paulo ");
                    break;

                case "SE":
                    Console.WriteLine(" Sergipe");
                    break;

                case "TO":
                    Console.WriteLine(" Tocantins ");
                    break;

                default:
                    Console.WriteLine(" Opção Inválida! ");
                    break;
            }
        }
        public static void Exercicio5()
        {

            int mes, dia;

            Console.WriteLine("Digite um número entre 1 e 12 para saber a estação do mês: ");
            mes = int.Parse(Console.ReadLine());

            switch (mes)
            {
                case 1:
                    Console.WriteLine("A estação é verão");
                    break;

                case 2:
                    Console.WriteLine("A estação é verão");
                    break;

                case 3:
                    Console.WriteLine("me informe o dia:");
                    dia = int.Parse(Console.ReadLine());
                    if (dia >= 20)
                        Console.WriteLine("a estaçao é outono");
                    else
                        Console.WriteLine("A estação é verão");
                    break;

                case 4:
                    Console.WriteLine("A estação é outono");
                    break;

                case 5:
                    Console.WriteLine("A estação é outono");
                    break;

                case 6:
                    Console.WriteLine("me informe o dia:");
                    dia = int.Parse(Console.ReadLine());
                    if (dia >= 20)
                        Console.WriteLine("a estaçao é inverno");
                    else
                        Console.WriteLine("A estação é outono");
                    break;

                case 7:
                    Console.WriteLine("a estaçao é inverno");
                    break;

                case 8:
                    Console.WriteLine("a estaçao é inverno");
                    break;

                case 9:
                    Console.WriteLine("me informe o dia:");
                    dia = int.Parse(Console.ReadLine());
                    if (dia >= 22)
                        Console.WriteLine("a estaçao é primavera");
                    else
                        Console.WriteLine("A estação é inverno");
                    break;

                case 10:
                    Console.WriteLine("a estaçao é primavera");
                    break;

                case 11:
                    Console.WriteLine("a estaçao é primavera");
                    break;

                case 12:
                    Console.WriteLine("me informe o dia:");
                    dia = int.Parse(Console.ReadLine());
                    if (dia >= 21)
                        Console.WriteLine("a estaçao é verão");
                    else
                        Console.WriteLine("A estação é primavera");
                    break;
            }
        }
        public static void Exercicio6()
        {

            float pesoh, altura, imc;

            Console.WriteLine("informe sua altura:");
            altura = float.Parse(Console.ReadLine());

            Console.WriteLine("informe o seu peso:");
            pesoh = float.Parse(Console.ReadLine());

            imc = pesoh / (altura * altura);

            if (imc < 18.5)
                Console.WriteLine("esta abaixo do peso");

            else if (imc == 18.5 && imc == 34.90)
                Console.WriteLine("Peso normal");

            else if (imc == 25.0 && imc == 29.9)
                Console.WriteLine("Sobrepeso");

            else if (imc == 30.0 && imc == 34.9)
                Console.WriteLine("obesidade grau 1");

            else if (imc == 35.0 && imc == 39.9)
                Console.WriteLine("obesidade de grau 2");

            else
                Console.WriteLine("Obesidade de grau 3(morbita)");

        }
        public static void Exercicio7()
        {

            float numero;
            int i;

            Console.WriteLine("digite um numero maior que zero:");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Divisores de " + numero + ":");


            i = 1;

            do
            {
                if (numero % i == 0)
                    Console.WriteLine(i);
                i++;

            } while (i <= numero);



        }
        static void Main(string[] args)
        {
            int opcao, f = 1;

            do
            {
                Console.WriteLine("====================================");
                Console.WriteLine("     Para Sair - digite 0           ");
                Console.WriteLine("Para executar exercício 1 - digite 1");
                Console.WriteLine("Para executar exercício 2 - digite 2");
                Console.WriteLine("Para executar exercício 3 - digite 3");
                Console.WriteLine("Para executar exercício 4 - digite 4");
                Console.WriteLine("Para executar exercício 5 - digite 5");
                Console.WriteLine("Para executar exercício 6 - digite 6");
                Console.WriteLine("Para executar exercício 7 - digite 7");
                Console.WriteLine("====================================");

                opcao = int.Parse(Console.ReadLine()); //lê a opção escolhida 

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigada, tchau!");
                        break;

                    case 1:
                        Exercicio1();
                        break;

                    case 2:
                        Exercicio2();
                        break;

                    case 3:
                        Exercicio3();
                        break;

                    case 4:
                        Exercicio4();
                        break;

                    case 5:
                        Exercicio5();
                        break;

                    case 6:
                        Exercicio6();
                        break;

                    case 7:
                        Exercicio7();
                        break;

                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }

                Console.WriteLine("Para continuar digita 1 para sim ou 0 para não");
                f = int.Parse(Console.ReadLine());

            } while (opcao != 0);
        }
    }
}
