using System; 
using System.Collections.Generic; 
using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema; 

namespace Api.Domain.Entities
{
    [Table("categoria")]
    public class CategoriaEntity
    {

        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.None)] 
        public int Cat_Id { get; set; } 

        [Display(Name = "Cat_Nome")] 
        [StringLength(25)] 
        public string Cat_Nome { get; set; }  
    }
}
