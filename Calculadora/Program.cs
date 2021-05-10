using System;
using System.Globalization;

namespace Calculadora {
    class Calc {
        static void Main(string[] args) {

            Console.WriteLine("              CALCULADORA               ");
            Console.WriteLine("    exemplo de operacão: 1 + 1 <Enter>; ");
            Console.WriteLine(" Digite <exit> para sair quando quiser: ");
            Console.WriteLine("----------------------------------------");

            bool isExit = false;
            while (!isExit) {
                try {
                    string expressao = Console.ReadLine();
                    if (expressao == "exit") {
                        isExit = true;
                    }

                    else {

                        double result = Calculadora.operacao(expressao);
                        Console.WriteLine("Resultado :");
                        Console.WriteLine(result.ToString("F3", CultureInfo.InvariantCulture));
                        Console.WriteLine("----------------------------------------");
                    }
                }


                catch (FormatException) {

                    Console.WriteLine("invalido, somente numeros !");
                    Console.WriteLine("----------------------------------------");
                }

                catch (Exception mens) {

                    Console.WriteLine(mens.Message);
                    Console.WriteLine("----------------------------------------");
                }

            }

        }


    }
}
