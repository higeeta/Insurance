using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SystemTest.Models
{
    public class User
    {
        public long UserId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string DOB { get; set; }
        public string Quote { get; set; }
        public int Coverage { get; set; }
    }
}