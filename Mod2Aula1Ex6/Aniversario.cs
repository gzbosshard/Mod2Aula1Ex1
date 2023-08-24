using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2Aula1Ex6
{
    public class Aniversario : CartaoWeb
    {
        public Aniversario(string destinatario)
        {
            Destinatario = destinatario;
        }

        public override string ShowMessage()
        {
            return $"Feliz Aniversário, {Destinatario}!";
        }

    }
}
