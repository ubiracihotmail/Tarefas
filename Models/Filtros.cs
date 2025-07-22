namespace Tarefas.Models
{
    public class Filtros
    {
        public Filtros(string filtroString)
        {
            FiltrosString = filtroString ?? "todos-todos-todos";
            string[] filtros = FiltrosString.Split('-');

            CategoriaId = filtros[0];
            Vencimento = filtros[1];
            StatusId = filtros[2];          
        }

        public string FiltrosString { get; set; }
        public string  CategoriaId { get; set; }
        public string StatusId { get; set; }
        public string Vencimento { get; set; }


        public bool TemCategoria => CategoriaId.ToLower() != "todos";
        public bool TemVencimento => Vencimento.ToLower() != "todos";
        public bool TemStatus => StatusId.ToLower() != "todos";

        public static Dictionary<string, string> VencimentosValoresFiltro =>
            new Dictionary<string, string>
            {
                {"futuro", "Futuro" },
                {"passado", "Passado" },
                {"hoje", "Hoje" }
            };

        public bool EPassado => Vencimento.ToLower() == "passado";
        public bool EFuturo => Vencimento.ToLower() == "futuro";
        public bool EHoje => Vencimento.ToLower() == "hoje";

    }
}
