using System.ComponentModel.DataAnnotations;

namespace AtendimentoMedico.Data
{
    public class Medico
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Sala { get; set; }
        
        public Atendimento Atendimento { get; set; }
    }
}