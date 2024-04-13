
DocViewer
Página
de 2
Páginas
Pontifícia Universidade Católica de Minas Gerais
Curso de Sistemas de Informação
Programação Orientada por Objetos
Simulado de Avaliação I
1. Crie uma classe chamada Número que seja responsável por fazer as operações de Soma, Subtração,
Multiplicação e Divisão de números inteiros positivos. Essa classe deve possuir dois atributos, Num1 e Num2 e os
métodos devidos para as operações descritas.
O programa principal deverá solicitar do usuário a entrada de dois números. Na definição das propriedades, crie
um código apropriado para que não se possam operar números negativos. Ao contrário, o valor 0 (zero) deverá
ser atribuído a eles.
Execute as operações e mostre cada resultado.
2. Crie uma classe chamada “CVetor” que defina um vetor de tamanho “n”. Crie métodos construtores para que:
• Se o usuário, no momento da instância da classe, passar algum valor como parâmetro, esse vetor
seja definido como o tamanho “n” do vetor;
• Se o usuário, no momento da instância da classe, não passar valor algum como parâmetro, o
programa solicite do usuário o tamanho “n” do vetor;
3. Faça um programa em C# .NET que seja capaz de cadastrar pacientes de uma clínica médica. Os dados a serem
armazenados são o Nome, Telefone, Data de Nascimento e Mail. As seguintes recomendações devem ser levadas
em consideração:
• Crie uma classe chamada Paciente com os atributos definidos devidamente encapsulados;
• A classe deve possuir dois métodos:
o O método “Cadastrar” solicita os dados devidos a um paciente e retorna esse objeto para o
programa principal. No programa principal esse objeto será armazenado em um vetor ou
um ArrayList.
o O método “Listar” deve receber esse vetor, ou o ArrayList, e listar na tela todos os dados
dos pacientes.
• No programa principal (main), declare um vetor ou ArrayList do tipo Paciente e um objeto do tipo
paciente. Em uma estrutura de repetição cadastre alguns pacientes e os liste.
4. O programa a seguir gerou um erro. Identifique-o e justifique uma forma de resolvê-lo.
class ABC
{
public static double Calcula(int x)
{
if (x % 2 == 0)
return x * 2;
else
return x / 3;
}
}
class Program
{
static void Main(string[] args)
{
ABC MeuABC = new ABC();
Console.WriteLine("Resultado = {0}", MeuABC.Calcula(5));
Console.ReadKey();
}
}
5. Considere uma academia de ginástica que precise de um sistema de informação capaz de organizar melhor o
cadastro de seus funcionários. A empresa possui professores e funcionários da administração em geral.
Para todos os funcionários a academia precisa cadastrar seus dados pessoais, como Nome, Endereço, Telefone,
Carteira de Trabalho e Salário. Especificamente se o funcionário for um professor é necessário armazenar
também a sua Especialização.
Crie um programa em C#.NET que crie uma classe chamada Funcionário e outra chamada de Professor, herdeira
da classe Funcionário, todas elas com os atributos definidos. Crie construtores nas classes que inicializem cada
atributo.
No programa principal uma estrutura de dados capaz de armazenar até 100 funcionários que trabalham em cada
uma das duas áreas descritas (Administração e Professor). O programa deverá também listar todos os
funcionários cadastrados.
Anotações
