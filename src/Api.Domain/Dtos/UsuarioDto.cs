using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos
{
    public class UsuarioDto
    {
        [Required(ErrorMessage = "Nome é um campo obrigatório")]
        [StringLength(60, ErrorMessage = "Nome deve ter no máximo {1} caracteres.")]
        public string Usu_Nome { get; set; }

        [Required(ErrorMessage = "Email é um campo obrigatório")]
        [EmailAddress(ErrorMessage = "E-mail em formato inválido.")]
        [StringLength(100, ErrorMessage = "Email deve ter no máximo {1} caracteres.")]        
        public string Usu_Login { get; set; }

        public string Usu_Senha { get; set; }

        public string Usu_SenhaConfirmar { get; set; }
    }
}
