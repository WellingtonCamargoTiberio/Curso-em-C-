using System;

namespace aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Olá ");
            if(args.GetLength(0)>0){ //condição... Se existir printa 
                Console.Write(args.GetValue(0)); // recebe uma matriz e posta a posição 0 gravada dentro dela
            }
            
        }
    }
}

