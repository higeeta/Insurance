using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SystemTest.Models
{
    public class Data
    {
        public static List<Quote> getQuoteData()
        {
            var data = new List<Quote> {
                new Quote {
                Number = "apz110",
                Status = "Active",
                Date = System.DateTime.Now.ToString("dd/mm/yyyy"),
                EffectiveDate = System.DateTime.Now.ToString("dd/mm/yyyy"),
                                
                }, new Quote {
                        Number = "Apz20",
                        Status = "Close",
                        Date = System.DateTime.Now.ToString("dd/mm/yyyy"),
                        EffectiveDate = System.DateTime.Now.ToString("dd/mm/yyyy"),
                        Applicant="CDK Global",
                
                }
            };
            return data;
        }
        public static List<User> getUserData()
        {
            var data = new List<User> {
                new User {
                UserId=1,
                FName = "John",
                LName = "Flamn",
                DOB = "11/11/1990",
                Quote="apz110"
                },
                new User {
                UserId=2,
                FName = "Alvin",
                LName = "Lagaspy",
                DOB = "11/11/1960",
                Quote="apz110"
                }
            };
            return data;
        }
        public static List<AdditionalInsure> getAdditionalInsurance()
        {
            var data = new List<AdditionalInsure> {                
                new AdditionalInsure {                
                }
            };
            return data;
        }
    }
}