using System.ComponentModel.DataAnnotations;

namespace AvaliacaoMVC.Models
{
    public class Aluno
    {
        public int AlunoId { get; set; }
        [Display(Name = "Nome do Aluno")]
        [Required(ErrorMessage = "Informe o Nome do Aluno")]
        public string? Nome { get; set; }
        [Range(3, 70, ErrorMessage = "Idade entre 3 e 70 anos")]
        [Required(ErrorMessage = "Informe a Idade do Aluno")]
        [Display(Name = "Idade")]
        public int Idade { get; set; }
        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "Informe o Endereço do Aluno")]
        public string? Endereco { get; set; }
        [Required(ErrorMessage = "CEP deve conter 8 números (sem traços ou espaços)")]
        [StringLength(8, ErrorMessage = "CEP deve conter 8 números (sem traços ou espaços)", MinimumLength = 8)]

        public string? CEP { get; set; }
        [Required(ErrorMessage = "Informe a Turma do Aluno")]
        public string? Turma { get; set; }
        [Range(1, 31, ErrorMessage = "Dia entre 1 e 31")]
        [Required(ErrorMessage = "Informe o Dia do Pagamento")]
        public int Dia { get; set; }
        [Required(ErrorMessage = "Informe o Valor da Mensalidade")]
        public decimal Mensalidade { get; set; }
    }
}
