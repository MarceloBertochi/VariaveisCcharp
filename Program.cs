using System;

namespace variaveis
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.Clear();

            string nome = "Marcelo";
            Console.WriteLine(nome);

            Console.WriteLine(); // WritleLine sem valor declarado, quebra uma linha. 

            int myNum = 15;
            Console.WriteLine(myNum);

            Console.WriteLine();

            int myNum2;
            myNum2 = 20;
            Console.WriteLine(myNum2);
            myNum2 = 30; // o valor da variável myNum passa a ser 30
            Console.WriteLine(myNum2);

            Console.WriteLine();

            double myDobleNum = 5.99D;
            Console.WriteLine(myDobleNum);
            Console.WriteLine();

            char myletter = 'A';
            Console.WriteLine(myletter);
            Console.WriteLine();

            bool myBool = true;
            Console.WriteLine(myBool);
            Console.WriteLine();
        }
    }
}