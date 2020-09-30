using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SystemTest.Models;



namespace SystemTest.Controllers
{   
    [RoutePrefix("api/Quote")]
    public class QuoteController : ApiController
    {
        // GET: api/Quote
        [Route("GetQuoteList")]        
        public List<Quote> Get()
        {             
            return Data.getQuoteData();          
        }

        // GET: api/Quote/5
        [Route("GetQuoteById")]
        public Quote Get(string id)
        {
            return Data.getQuoteData().Where(a => a.Number==id).FirstOrDefault(); 
        }

        // POST: api/Quote
        [Route("addUserToQuote")]
        public string Post([FromBody]User reqData,[FromUri]string id)
        {
            var generator = new Random();
            int randomNumber = generator.Next(5, 100);

            //Adding user to the quote 
            reqData.Coverage=randomNumber;
            Quote qData= Data.getQuoteData().Where(a => a.Number == id).FirstOrDefault();
            qData.Users.Add(reqData);

            //Adding UserId and Quote into the AdditionalInsure table
            AdditionalInsure addInsu = new AdditionalInsure();
            addInsu.QuoteId = id;
            addInsu.UserId = reqData.UserId;
            addInsu.Coverage = randomNumber;

            return randomNumber.ToString()+" %";
        }

        // PUT: api/Quote/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Quote/5
        public void Delete(int id)
        {
        }
    }
}
