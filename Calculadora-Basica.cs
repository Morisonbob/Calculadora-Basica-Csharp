using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args){
            Console.WriteLine("Calculadora rustica");
            Console.WriteLine("\nEscolha que tipo de operacao voce deseja fazer");
            Console.WriteLine("\n1.Adicao");
            Console.WriteLine("2.Subtracao");
            Console.WriteLine("3.Multiplicacao");
            Console.WriteLine("4.Divisao");
            Console.Write("\nDigite o numero correspondente a operacao e aperte enter: ");
            int choice, res, pri, sec;
            choice = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(choice); Checking the input
            switch (choice)
            {
                case 1:
                    Console.Write("Digite o primeiro numero e pressione enter: ");
                    pri = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite o segundo numero e pressione enter: ");
                    sec = Convert.ToInt32(Console.ReadLine());
                    res = pri + sec;
                    Console.WriteLine("O resultado e: " + res);
                    break;

                case 2:
                    Console.Write("Digite o primeiro numero e pressione enter: ");
                    pri = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite o segundo numero e pressione enter: ");
                    sec = Convert.ToInt32(Console.ReadLine());
                    res = pri - sec;
                    Console.WriteLine("O resultado e: " + res);
                    break;

                case 3:
                    Console.Write("Digite o primeiro numero e pressione enter: ");
                    pri = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite o segundo numero e pressione enter: ");
                    sec = Convert.ToInt32(Console.ReadLine());
                    res = pri * sec;
                    Console.WriteLine("O resultado e: " + res);
                    break;

                case 4:
                    Console.Write("Digite o primeiro numero e pressione enter: ");
                    pri = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite o segundo numero e pressione enter: ");
                    sec = Convert.ToInt32(Console.ReadLine());
                    res = pri / sec;
                    Console.WriteLine("O resultado e: " + res);
                    break;
            }
        }
    }
}
