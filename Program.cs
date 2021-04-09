using System;

namespace JurosSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            string Entrada1, Entrada2, Entrada3;
            int Tempo;
            decimal Capital, Taxa,JurosFinal,Montante;

            Console.Beep();
            Console.WriteLine("----Cálculo de Juros Simples-----");
            Console.WriteLine();
            Console.Write("Digite o valor do Capital (em R$): ");
            Entrada1 = Console.ReadLine();
            Console.Write("Digite a Taxa de Juros (em %): ");
            Entrada2=Console.ReadLine();
            Console.Write("Digite o Tempo (em meses): ");
            Entrada3=Console.ReadLine();    

            Capital = Convert.ToDecimal(Entrada1);
            Taxa = Convert.ToDecimal(Entrada2);
            Tempo = Convert.ToInt16(Entrada3);
           
            JurosFinal= Capital*(Taxa/100)*Tempo;
            Montante= (Capital+JurosFinal);

            Console.Beep();
            Console.WriteLine("----------");
            Console.ForegroundColor=ConsoleColor.DarkRed;
            Console.WriteLine("\n---Resultados---");
            Console . ResetColor ();
            Console.WriteLine($"Juros(R$): {JurosFinal}");
            Console.WriteLine($"Montante(R$): {Montante}");
            Console.WriteLine("----------");
        }
    }
}
