using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Domain.Entities
{
    [Table("cliente")]
    public class ClienteEntity
    {
        [Key]         
        [StringLength(20)] 
        public string Cli_Id { get; set; } 
        
        public int? Cli_IdRota { get; set; } 

        [StringLength(50)] 
        public string Cli_Nome { get; set; } 
        
        [StringLength(50)] 
        public string Cli_Fantasia { get; set; } 
        
        [StringLength(1)] 
        public string Cli_TipoPessoa { get; set; }  
        
        [StringLength(18)] 
        public string Cli_CnpjCpf { get; set; } 
        
        [StringLength(50)] 
        public string Cli_Endereco { get; set; } 
        
        [StringLength(6)] 
        public string Cli_Numero { get; set; } 
        
        [StringLength(25)] 
        public string Cli_Bairro { get; set; } 
        
        [StringLength(10)] 
        public string Cli_Cep { get; set; } 
        
        [StringLength(14)] 
        public string Cli_Telefone { get; set; } 
        
        [StringLength(14)] 
        public string Cli_Celular { get; set; } 

        [StringLength(1)] 
        public string Cli_Bloqueado { get; set; }  

        [Column(TypeName = "date")] 
        public DateTime? Cli_UltimaCompra { get; set; } 
        
        [StringLength(2)] 
        public string Cli_UF { get; set; } 
        
        [StringLength(50)] 
        public string Cli_Municipio { get; set; } 
        
        [StringLength(50)] 
        public string Cli_Lat { get; set; } 

        [StringLength(50)] 
        public string Cli_Lng { get; set; } 
    }
}
