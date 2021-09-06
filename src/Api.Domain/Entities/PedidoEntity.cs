using System; 
using System.Collections.Generic; 
using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema; 

namespace Api.Domain.Entities
{
    [Table("pedido")]
    public class PedidoEntity
    {
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.None)] 
        [StringLength(100)]
        public string Ped_Id { get; set; } 

        public int? Ped_IdVendedor { get; set; } 
        
        [StringLength(20)] 
        public string Ped_IdCliente { get; set; } 
        
        [Column(TypeName = "date")] 
        public DateTime? Ped_Data { get; set; } 
        
        public int? Ped_Conferido { get; set; }

        public virtual ICollection<PedidoItemEntity> PedidoItemEntity { get; set; }
        
    }
}
