namespace Mod2Aula1Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Futebol novoJogo = new();

            string inicio = novoJogo.IniciarJogo();
            string fim = novoJogo.FinalizarJogo();
            string descricao = novoJogo.ExibirDescricao();

            Console.WriteLine(inicio);
            Console.WriteLine(fim);
            Console.WriteLine(descricao);

            Console.ReadKey();
        }
    }
}