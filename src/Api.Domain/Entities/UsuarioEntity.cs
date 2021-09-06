using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Domain.Entities
{
   [Table("usuarios")]
   public class UsuarioEntity
   {
      [Key]
      [DatabaseGenerated(DatabaseGeneratedOption.None)]
      public int id { get; set; }
        
      [Required]
      public int? cliente_id { get; set; }

      [Required]
      public int vendedor_id { get; set; }
        
      [Required]
      [StringLength(191)]
      public string nome { get; set; }
        
      [Required]
      [StringLength(191)]
      public string email { get; set; }
        
      [StringLength(191)]
      public string foto { get; set; }        
        
      [Required]
      public int? limite_dia { get; set; }
        
      public int? codigo_produtor { get; set; }
        
      public int? codigo_agencia { get; set; }        
        
      [StringLength(191)]
      public string password { get; set; }

      [StringLength(200)]
      public string senha { get; set; }

      [NotMapped]
      [StringLength(200)]
      public string confirmasenha { get; set; }
        
      [StringLength(100)]
      public string remember_token { get; set; }

      [Display(Name = "created_at")]
      public DateTime created_at { get; set; }

      [Display(Name = "updated_at")]
      public DateTime updated_at { get; set; }

      [NotMapped]
      public string emp { get; set; }
      
   }
}
