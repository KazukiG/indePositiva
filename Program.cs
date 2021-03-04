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
            if (num % 2 == 0)
                Console.WriteLine("*R: c*");
            else
                Console.WriteLine("*R: e*");

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

            Console.WriteLine("Nome da mãe é: 'Luiza Carvalho'");

            return validador(randomNum);
        }
        private static int pergunta2(Random random)
        {
            int randomNum = random.Next();

            Console.WriteLine("\nNome da CPF é: '123.123.123-12'");

            return validador(randomNum);
        }
        private static int pergunta3(Random random)
        {
            int randomNum = random.Next();

            Console.WriteLine("\nO endereço é: 'Rua Brasil'");

            return validador(randomNum);
        }
        private static int pergunta4(Random random)
        {
            int randomNum = random.Next();

            Console.WriteLine("\nNome da CPF é: '123.123.123-12'");

            return validador(randomNum);
        }
        private static int pergunta5(Random random)
        {
            int randomNum = random.Next();

            Console.WriteLine("\nNome da CPF é: '123.123.123-12'");

            return validador(randomNum);
        }
    }
}
