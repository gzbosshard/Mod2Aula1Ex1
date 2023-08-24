namespace Mod2Aula1Ex6
{

    internal class Program
    {
        private static void Main(string[] args)
        {
            Aniversario aniversario = new("Gabi");
            Natal natal = new("Gabi");
            DiaDosNamorados namorados = new("Gabi");

            Console.WriteLine(aniversario.ShowMessage());
            Console.WriteLine(natal.ShowMessage());
            Console.WriteLine(namorados.ShowMessage());
        }
    }
}