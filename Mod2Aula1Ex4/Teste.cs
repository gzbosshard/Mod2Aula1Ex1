using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2Aula1Ex4
{
    public static class Teste
    {
        public static string DetalhesFigura(Figura figura)
        {
            Retangulo retangulo = new();

            retangulo.cor = "Azul";
            retangulo.lado1 = 3.5;
            retangulo.lado2 = 2;

            return $"Cor da figura: {retangulo.cor} - Área da figura: {retangulo.Area()}";

        }
    }


}
