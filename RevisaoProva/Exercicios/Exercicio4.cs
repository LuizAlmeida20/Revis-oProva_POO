/*
    O erro está no fato de que a função calcula é estática. Portanto, para invocá-la, é necessário utilizar o nome da classe.
        Como foi escrito: meuABC.Calcula(5)
        Como é o correto: ABC.Calcula(5)
    
*/

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
        Console.WriteLine("Resultado = {0}", ABC.Calcula(5));
        Console.ReadKey();
    }
}