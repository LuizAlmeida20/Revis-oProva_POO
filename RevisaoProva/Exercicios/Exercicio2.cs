using System;

namespace ConsoleApp
{
    public class CVetor{
        private int[] vetor;
        
        public CVetor(int tamanho){
            this.vetor = new int[tamanho];
        }

        public CVetor(){
            Console.Write("Infome o tamanho do vetor a ser criado: ");
            int tamanho = int.Parse(Console.ReadLine());
            vetor = new int[tamanho];
        }

        public void exibeTamanho(){
            Console.WriteLine("Tamanho do vetor: " + vetor.Length);
        }

        public static void testeExercicio2(){
            System.Console.WriteLine();

            CVetor vetor1 = new CVetor(8);
            vetor1.exibeTamanho();

            System.Console.WriteLine();
            
            CVetor vetor2 = new CVetor();
            vetor2.exibeTamanho();
        }
    }
}