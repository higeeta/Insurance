using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SystemTest.Models
{
    public class AdditionalInsure
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string QuoteId { get; set; }
        public int Coverage { get; set; }
    }
}