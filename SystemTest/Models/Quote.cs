using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SystemTest.Models
{
    public class Quote
    {
        public string Number { get; set; }
        public string Applicant { get; set; } = "jarustech";
        public string Status { get; set; }
        public string Date { get; set; }
        public string EffectiveDate { get; set; }
        public string PreferredOption { get; set; } = "basic";
        public string Basic { get; set; } = "$ 680";
        public string Preffered { get; set; } = "$ 850";
        public string Premier { get; set; } = "$ 1050";

        public List<User> Users { get; set; }
        public Quote()
        {
            Users = new List<User>();
        }
    }
}