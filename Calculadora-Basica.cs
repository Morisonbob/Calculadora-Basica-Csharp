using System;



    class Program
    {
        static void Main(string[] args)
        {
            calc n = new calc();
            n.Menu();
            String choice;
            int numero, numero_2;
            double res, pri, sec;
            bool controle = true;
            while (controle)
            {
                choice = Console.ReadLine();
                bool checagem = int.TryParse(choice, out numero);
                while (!checagem)
                {
                    Console.WriteLine("Entrada invalida");
                    Console.ReadKey();
                    Console.Clear();
                    n.Menu();
                    choice = Console.ReadLine();
                    checagem = int.TryParse(choice, out numero);

                }
                    numero_2 = int.Parse(choice);
                
                switch (numero_2)
                {
                    case 1:
                        Console.Write("Digite o primeiro numero e pressione enter: ");
                        pri = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite o segundo numero e pressione enter: ");
                        sec = Convert.ToDouble(Console.ReadLine());
                        res = pri + sec;
                        Console.WriteLine("O resultado e: " + res);
                        Console.ReadKey();
                        Console.Clear();
                        n.Menu();
                        break;

                    case 2:
                        Console.Write("Digite o primeiro numero e pressione enter: ");
                        pri = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite o segundo numero e pressione enter: ");
                        sec = Convert.ToDouble(Console.ReadLine());
                        res = pri - sec;
                        Console.WriteLine("O resultado e: " + res);
                        Console.ReadKey();
                        Console.Clear();
                        n.Menu();
                        break;

                    case 3:
                        Console.Write("Digite o primeiro numero e pressione enter: ");
                        pri = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite o segundo numero e pressione enter: ");
                        sec = Convert.ToDouble(Console.ReadLine());
                        res = pri * sec;
                        Console.WriteLine("O resultado e: " + res);
                        Console.ReadKey();
                        Console.Clear();
                        n.Menu();
                        break;

                    case 4:
                        Console.Write("Digite o primeiro numero e pressione enter: ");
                        pri = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite o segundo numero e pressione enter: ");
                        sec = Convert.ToDouble(Console.ReadLine());
                        res = pri / sec;
                        Console.WriteLine("O resultado e: " + res);
                        Console.ReadKey();
                        Console.Clear();
                        n.Menu();
                        break;

                    case 5:
                        Environment.Exit(1);
                        break;

                    default:
                        Console.WriteLine("\nEntrada invalida.");
                        Console.ReadKey();
                        Console.Clear();
                        n.Menu();
                        break;
                }
            }
        }


    public class calc
    {
        public void Menu()
        {
            Console.WriteLine("Calculadora rustica");
            Console.WriteLine("\nEscolha que tipo de operacao voce deseja fazer:");
            Console.WriteLine("\n1.Adicao;");
            Console.WriteLine("2.Subtracao;");
            Console.WriteLine("3.Multiplicacao;");
            Console.WriteLine("4.Divisao;");
            Console.WriteLine("\nDigite 5 para sair.");
            Console.Write("\nDigite o numero correspondente a operacao e aperte enter: ");
        }
    }
}
