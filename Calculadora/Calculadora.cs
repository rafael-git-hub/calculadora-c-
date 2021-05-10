using System;
using Calculadora.Exceptions;
using System.Globalization;

namespace Calculadora {

    class Calculadora {

        public static double operacao(string expressao) {

            string[] operacao = expressao.Split(' ');

            double valor1 = double.Parse(operacao[0], CultureInfo.InvariantCulture);
            char operador = char.Parse(operacao[1]);
            double valor2 = double.Parse(operacao[2], CultureInfo.InvariantCulture);
            double resultado = 0;

            if (!(operador == '+' || operador == '-' || operador == '*' || operador == '/')) {
                throw new DomainException("invalido, somente operadores!");
            }

            

            switch (operador) {
                case '+':
                    resultado = Somar(valor1, valor2);
                    break;

                case '-':
                    resultado = subtrair(valor1, valor2);
                    break;

                case '*':
                    resultado = Multiplicar(valor1, valor2);
                    break;

                case '/':
                    resultado = Dividir(valor1, valor2);
                    break;
            }



            return resultado;
        }



        public static double Somar(double a, double b) {
            return a + b;
        }

        public static double subtrair(double a, double b) {
            return a - b;
        }

        public static double Multiplicar(double a, double b) {
            return a * b;
        }

        public static double Dividir(double a, double b) {
            if (b == 0) {
                throw new DomainException("Não pode ser dividido por 0");
                
            }
            
            return a / b;
        }
    }
}
