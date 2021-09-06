using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Domain.Entities
{
    [Table("produto")]
    public class ProdutoEntity
    {
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.None)] 
        public int Pro_Id { get; set; } 
        
        [StringLength(50)] 
        public string Pro_Nome { get; set; } 
        
        public int? Pro_IdCategoria { get; set; } 

        [StringLength(3)] 
        public string Pro_Unidade { get; set; } 
        
        public double Pro_Preco { get; set; } 

    }
}
