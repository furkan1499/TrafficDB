using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Mvc;
using TrafficDB;

namespace Traffic.Web.Api.Controllers
{
    public class DataController : ApiController
    {
        private MyDB2 db = new MyDB2();

        public Lamb Get(string id)
        {
            return db.Lambs.FirstOrDefault(x => x.LambNumber == id);
        }
        public List<Lamb> Get()
        {
            return db.Lambs.ToList();
        }
      

        [System.Web.Http.HttpPost]
        public bool Post(string LambNumber, WhichColor whichColor)
        {
            try
            {
                using (var db = new MyDB2())
                {
                    var data = db.Lambs.Where(x => x.LambNumber == LambNumber && x._WhichColor == whichColor).ToList();
                    db.Lambs.Add(new Lamb
                    {
                        LambNumber = LambNumber,
                        _WhichColor = whichColor

                    });
                    db.SaveChanges();
                    return true;
                }


            }
            catch (Exception e)
            {

                return false;
            }

        }
        //public string Get(string LambNumber)
        //{
        //    try
        //    {
        //        using (var db = new MyDB2())
        //        {
        //            var data = db.Lambs.Where(x => x.LambNumber == LambNumber).FirstOrDefault();

        //            return data._WhichColor.ToString();

        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw;
        //    }

        //}



    }
}
