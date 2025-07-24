using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Tarefas.Models
{
    public class Tarefa
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "Preencha a Descrição!")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Preencha a Data de Vencimento!")]
        public DateTime? DataDeVencimento { get; set; }
        [Required(ErrorMessage = "Selecione uma Categoria!")]
        public string CategoriaId { get; set; }

        [ValidateNever]
        public Categoria Categoria { get; set; }

        [ValidateNever]
        [Required(ErrorMessage = "Selecione um Status!")]
        public string StatusId { get; set; }

        [ValidateNever]
        public Status Status { get; set; }
        public bool Atrasado => StatusId == "aberto" && DataDeVencimento < DateTime.Today;
    }
}