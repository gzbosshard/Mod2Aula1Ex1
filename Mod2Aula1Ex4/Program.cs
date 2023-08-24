namespace Mod2Aula1Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new();

            string teste = Teste.DetalhesFigura(retangulo);

            Console.WriteLine(teste);

        }
    }
}