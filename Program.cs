using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indePositiva
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            Random random = new Random();

            cont += (pergunta1(random));
            cont += (pergunta2(random));
            cont += (pergunta3(random));
            if (cont < 3)
            {
                cont += (pergunta4(random));
                cont += (pergunta5(random));
            }
            
            if (cont < 3)
                Console.WriteLine("\n-Justificativa-");

            Console.WriteLine("\nRespostas certas: "+cont);
            Console.ReadLine();
        }

        private static int validador(int num)
        {
            string resp = Console.ReadLine();

            if (num % 2 == 0)
            {
                if (resp == "c")
                    return 1;
                else
                    return 0;
            }
            else
            {
                if (resp == "e")
                    return 1;
                else
                    return 0;
            }
        }
        private static int pergunta1(Random random)
        {
            int randomNum = random.Next();

            if (randomNum % 2 == 0)
            {
                Console.WriteLine("Nome da mãe é: '[NOME CERTO]'");
                Console.WriteLine("*R: c*");
            }
            else
            {
                Console.WriteLine("Nome da mãe é: '[NOME ERRADO]'");
                Console.WriteLine("*R: e*");
            }

            return validador(randomNum);
        }
        private static int pergunta2(Random random)
        {
            int randomNum = random.Next();

            if (randomNum % 2 == 0)
            {
                Console.WriteLine("O endereço é: '[ENDEREÇO CERTO]'");
                Console.WriteLine("*R: c*");
            }
            else
            {
                Console.WriteLine("O endereço é: '[ENDEREÇO ERRADO]'");
                Console.WriteLine("*R: e*");
            }

            return validador(randomNum);
        }
        private static int pergunta3(Random random)
        {
            int randomNum = random.Next();

            if (randomNum % 2 == 0)
            {
                Console.WriteLine("Data de nascimento é: '[DATA CERTA]'");
                Console.WriteLine("*R: c*");
            }
            else
            {
                Console.WriteLine("Data de nascimento é: '[DATA ERRADA]'");
                Console.WriteLine("*R: e*");
            }

            return validador(randomNum);
        }
        private static int pergunta4(Random random)
        {
            int randomNum = random.Next();

            if (randomNum % 2 == 0)
            {
                Console.WriteLine("Nome é: '[NOME CERTO]'");
                Console.WriteLine("*R: c*");
            }
            else
            {
                Console.WriteLine("Nome é: '[NOME ERRADO]'");
                Console.WriteLine("*R: e*");
            }

            return validador(randomNum);
        }
        private static int pergunta5(Random random)
        {
            int randomNum = random.Next();

            if (randomNum % 2 == 0)
            {
                Console.WriteLine("CPF é: '[CPF CERTO]'");
                Console.WriteLine("*R: c*");
            }
            else
            {
                Console.WriteLine("CPF é: '[CPF ERRADO]'");
                Console.WriteLine("*R: e*");
            }

            return validador(randomNum);
        }
    }
}
