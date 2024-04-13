using System;

namespace ConsoleApp
{
    class Numero{
        private double num1;
        private double num2;

        //e posivel fazer o mesmo método abaixo com return, mas seriam necessárias algumas adaptações
        public void verificaNegativo(ref double x, ref double y){
            if(x < 0)
                x = 0;
            if(y < 0)
                y = 0;
        }
        
        public void leNumeros(){
            Console.Write("Informe um valor para o número 1: ");
            this.num1 = double.Parse(Console.ReadLine());
            // this.num1 = verificaNegativo(x);
            Console.Write("Informe um valor para o número 2: ");
            this.num2 = double.Parse(Console.ReadLine());
            // this.num2 = verificaNegativo(x);
            this.verificaNegativo(ref num1, ref num2);
            Console.WriteLine("Numero 1: " + this.num1 + " Numero 2: " + this.num2);
        }

        public double soma(){
            return this.num1 + this.num2;
        }

        public double subtracao(){
            return this.num1 - this.num2;
        }

        public double multiplicacao(){
            return this.num1 * this.num2;
        }

        public double divisao(){
            return this.num1 / this.num2;
        }

        public static void testeExercicio1(){
            Numero numero = new Numero();
            numero.leNumeros();
            System.Console.WriteLine("Resultado da soma.........: " + numero.soma());
            System.Console.WriteLine("Resultado da subtração....: " + numero.subtracao());
            System.Console.WriteLine("Resultado da multiplicação: " + numero.multiplicacao());
            System.Console.WriteLine("Resultado da divisão......: " + numero.divisao());
        }
    }
    
}