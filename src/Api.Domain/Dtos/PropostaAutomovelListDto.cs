
using System;

namespace Api.Domain.Dtos
{
    public class PropostaAutomovelListDto
    {
        public string NUMAPOLICE { get; set; }
        public string NUMPROPOSTA { get; set; }
        public string NUMENDOSSO { get; set; }
        public string NOME { get; set; }
        public DateTime? DATAINICIOVIGENCIA { get; set; }
        public DateTime? DATAFINALVIGENCIA { get; set; }


    }
}
