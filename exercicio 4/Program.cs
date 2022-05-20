using System;

namespace exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, e, i, o, u;
            string letra;
            
            Console.WriteLine("escolha uma letra");
            letra = Console.ReadLine();


            if (letra == "a" ||letra == "e" ||letra == "i" ||letra == "o" ||letra == "u") 
            {
                Console.WriteLine("Essa letra é uma vogal!");
            }
            else 
            {
                Console.WriteLine("Essa letra é uma consoante!");
            }
                

            


        }
    }
}
