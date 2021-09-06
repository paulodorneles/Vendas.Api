using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos
{
    public class ProfissaoDto
    {
        [StringLength(30, ErrorMessage = "Email deve ter no máximo {1} caracteres.")] 
        public string PROFISSAO { get; set; } 
   
    }
}
