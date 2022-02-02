using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;

namespace AtendimentoMedico.Data
{
    public class Atendimento 
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(128)]
        public string Nome { get; set; }
        
        public Prioridade Prioridade { get; set; }
        
        public bool Atendido { get; set; }
    }

    public enum Prioridade
    {
        [Display(Name = "Laranja")]
        P1,
        [Display(Name = "Amarelo")]
        P2,
        [Display(Name = "Verde")]
        P3,
        [Display(Name = "Azul")]
        P4
    }
    
    
    
}