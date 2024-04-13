using System;
using System.Collections;

namespace ConsoleApp
{
    public class Paciente{
        private string nome;
        private string telefone;
        private string dataNascimento;
        public string mail;

        public void cadastrar(){
            Console.Write("Informe o nome do paciente..............: ");
            this.nome= Console.ReadLine();
            Console.Write("Informe o telefone do paciente..........: ");
            this.telefone= Console.ReadLine();
            Console.Write("Informe a data de nascimento do paciente: ");
            this.dataNascimento= Console.ReadLine();
            Console.Write("Informe o e-mail do paciente............: ");
            this.mail= Console.ReadLine();
        }

        public void exibePaciente(){
            System.Console.WriteLine("Nome...............: " + this.nome);
            System.Console.WriteLine("Telefone...........: " + this.telefone);
            System.Console.WriteLine("Data de nascimento.: " + this.dataNascimento);
            System.Console.WriteLine("E-mail.............: " + this.mail);
        }

        public static void listar(Paciente[] arrayPaciente){
            for(int i  = 0; i < arrayPaciente.Length; i++){
            System.Console.WriteLine("\nNúmero do paciente: " + i);
                arrayPaciente[i].exibePaciente();
            }
        }

        public static void testeExercicio3(){
            Paciente paciente;
            
            System.Console.Write("Quantos pacientes devem ser cadastrados: ");
            int n = int.Parse(Console.ReadLine());

            Paciente[] arrayPaciente = new Paciente[n];
            
            for(int i = 0; i < n; i++){
                System.Console.WriteLine("\nPaciente número " + i);
                paciente = new Paciente();
                paciente.cadastrar();
                arrayPaciente[i] = paciente;
            }

            Paciente.listar(arrayPaciente);
        }


    }
}