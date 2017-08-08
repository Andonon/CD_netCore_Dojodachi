using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
 
namespace dojodachi.Controllers
{
    public class DachiController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            if(HttpContext.Session.GetObjectFromJson<Dachi>("DachiData") == null)
            {
                HttpContext.Session.SetObjectAsJson("DachiData", new Dachi());
            }            
            var CurrDachiData = HttpContext.Session.GetObjectFromJson<Dachi>("DachiData");
            int CurrEnergy = CurrDachiData.energy;
            int CurrFullness = CurrDachiData.fullness;
            int CurrHappiness = CurrDachiData.happiness;
            int CurrMeals = CurrDachiData.meals;

            // Console.WriteLine("testing DachoiData");
            // Console.WriteLine("Energy" + sampledata.energy);
            // Console.WriteLine("Fullness" + sampledata.fullness);
            // Console.WriteLine("Happiness" + sampledata.happiness);
            // Console.WriteLine("Meals" + sampledata.meals);
            return View("Index");
        }

        [HttpGet]
        [Route("reset")]
        public IActionResult Reset()
        {
            // HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("feed")]
        public IActionResult FeedDachi()
        {
            
            
            return View("Index");
        }
    }
    public static class SessionExtensions
    {
        // We can call ".SetObjectAsJson" just like our other session set methods, by passing a key and a value
        public static void SetObjectAsJson(this ISession session, string key, object value)
        {
            // This helper function simply serializes theobject to JSON and stores it as a string in session
            session.SetString(key, JsonConvert.SerializeObject(value));
        }
        
        // generic type T is a stand-in indicating that we need to specify the type on retrieval
        public static T GetObjectFromJson<T>(this ISession session, string key)
        {
            string value = session.GetString(key);
            // Upone retrieval the object is deserialized based on the type we specified
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }
}
