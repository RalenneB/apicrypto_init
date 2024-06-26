using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apicrypto.Dtos.Comment
{
    public class CommentDto
    {
        public int? CryptocurrencyId {get; set; }
        public int? DcaInvestmentId {get; set; }
        public int Id {get; set;}
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}