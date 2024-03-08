using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insere uma string: ");
            string str = Console.ReadLine();

            Console.WriteLine("Insere um caracter: ");
            string read = Console.ReadLine();
            char chr = char.Parse(read);

            foreach (char c in str)
            {
                if (c == chr)
                {
                    Console.Write("X");
                }
                else
                {
                    Console.Write(c);
                }
            }
        }
    }
}
