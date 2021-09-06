using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Domain.Entities
{
   [Table("usuario")]
   public class UsuarioEntity
   {
      [Key]
      [DatabaseGenerated(DatabaseGeneratedOption.None)]
      public int Usu_Id { get; set; }          
             
      [Required]
      [StringLength(40)]
      public string Usu_Nome { get; set; }
        
      [Required]
      [StringLength(20)]
      public string Usu_Login { get; set; }

      [Required]
      [StringLength(100)]
      public string Usu_Senha { get; set; }

      [StringLength(100)]
      [NotMapped]
      public string Usu_SenhaConfirma { get; set; }
      
   }
}
