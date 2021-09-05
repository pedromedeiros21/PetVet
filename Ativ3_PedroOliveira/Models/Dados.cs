using System.Collections.Generic;

namespace Ativ3_PedroOliveira.Models
{
    public static class Dados
    {
        private static readonly List<AgendamentoModel> _dados = new List<AgendamentoModel>();

        public static void Incluir(AgendamentoModel agendamentoModel) => _dados.Add(agendamentoModel);

        public static List<AgendamentoModel> Listar() => _dados;
    }
}
