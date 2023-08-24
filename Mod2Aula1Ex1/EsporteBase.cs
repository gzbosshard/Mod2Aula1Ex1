using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2Aula1Ex1
{
    public abstract class EsporteBase
    {
        public abstract int QuantidadeJogadoresPorTime { get; set; }
        public abstract int TempoDeJogoEmMinutos { get; set; }

        public abstract string IniciarJogo();
        public abstract string FinalizarJogo();
        public abstract string ExibirDescricao();
    }
}
