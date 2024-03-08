using System;

namespace RightSize
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Argumentos com comprimento superior a 3 caracteres:");

            foreach (string argument in args)
            {
                if (argument.Length > 3 && argument.Length <= 6)
                {
                    Console.WriteLine(argument);
                }
                else if (argument.Length > 6)
                {
                    break;
                }
            }
        }
    }
}