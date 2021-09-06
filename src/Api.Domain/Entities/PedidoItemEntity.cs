using System; 
using System.Collections.Generic; 
using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema;  

namespace Api.Domain.Entities
{
    [Table("pedidoitem")] 
    public class PedidoItemEntity
    {
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.None)] 
        public int Pei_Id { get; set; }  

        [StringLength(100)] 
        [ForeignKey("PedidoEntity")]
        public string Pei_IdPedido { get; set; }         

        public int? Pei_IdProduto { get; set; }         

        public double? Pei_Qtde { get; set; }         

        [StringLength(20)] 
        public string Pei_SubTotal { get; set; } 

        public PedidoEntity PedidoEntity { get; set; }        
    }
}
