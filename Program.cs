using Entities;
using Entities.Exceptions;
using System;

namespace OrganizeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para converter um numero inteiro para o maior ou menor possivél.");
            try
            {
                Console.Write("Você deseja converter para Maior ou Menor (H/L)? ");
                char typeConversion = char.Parse(Console.ReadLine().ToLower());

                if (typeConversion != 'l' && typeConversion != 'h')
                {
                    throw new OrganizeExceptions("Tipo de seleção de conversão invalido.");
                }

                Console.Write("Entre com um numero inteiro: ");
                Organize organizeNumbers = new Organize(int.Parse(Console.ReadLine().Trim()));
                Console.WriteLine("Numero digitado: " + organizeNumbers.Number);

                if (typeConversion == 'l')
                {
                    Console.WriteLine("Menor numero obtido: " + organizeNumbers.MinorNumber());
                }
                else if (typeConversion == 'h')
                {
                    Console.WriteLine("Maior numero obtido: " + organizeNumbers.MajorNumber());
                }

            }
            catch (OrganizeExceptions e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
