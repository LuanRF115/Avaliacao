using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avaliação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 0;
            double avaliação = 0;
            bool flag = false;

            try
            {

                while (!flag)
                {
                    Console.Write("\nDigite a Idade do funcionario ( ou 'S' para sair): ");
                    string inputIdade = Console.ReadLine();

                    if (inputIdade.ToUpper() == "S")
                    {
                        Console.WriteLine("\nPrograma encerrado.");
                        return;
                    }

                    try
                    {
                        idade = int.Parse(inputIdade);

                        if (idade < 18 || idade > 75)
                        {
                            Console.WriteLine("\nErro: Digite uma entrada valida entre 18 e 75.");
                            continue;


                        }

                        flag = true;

                    }
                    catch (FormatException)
                    {


                        Console.WriteLine("\nERRO: Por favor, digite um valor numérico válido.");
                       
                    }
                }

                flag = false;

                while (!flag)
                {

                    Console.Write("\nDigite o numero da avaliação ou 'S' para sair: ");
                    string inputAvaliação = Console.ReadLine();

                    if (inputAvaliação.ToUpper() == "S")
                    {

                        Console.WriteLine("\nPrograma encerrado.");
                        return;
                    }

                    try
                    {

                        avaliação = int.Parse(inputAvaliação);

                        if (avaliação < 80 || avaliação > 100)
                        {
                            Console.WriteLine("\nErro: Digite uma entrada valida entre 80 e 100.");
                            continue;


                        }

                        flag = true;
                    }
                    catch (FormatException)
                    {


                        Console.WriteLine("\nERRO: Por favor, digite um valor numérico válido.");


                    }
                }
                string resultado;
                if (idade <= 25 && avaliação >= 80)
                {

                    resultado = "Subsídio Concedido";


                }
                else
                {

                    resultado = "Subsídio Não Concedido";

                }
                Console.WriteLine($"\n{resultado}.");
            }
            finally
            {
                Console.WriteLine("Resultado concluída.");
                Console.ReadLine();

            }







        }
    }
}
