using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CarPark.User.Models;
using MongoDB.Driver;
using MongoDB.Bson;
using Microsoft.Extensions.Localization;
using System.Globalization;
using System.Threading;
using Newtonsoft.Json;
using CarPar.Entities.Concrete;

namespace CarPark.User.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStringLocalizer<HomeController> _localizer;
        private readonly MongoClient client;
        public HomeController(ILogger<HomeController> logger, IStringLocalizer<HomeController> localizer)
        {
            _logger = logger;
            _localizer = localizer;
            //client = new MongoClient("mongodb+srv://yildizmahmut:****@carparkcluster.wweao.mongodb.net/CarParkDB?retryWrites=true&w=majority");

        }

        public IActionResult Index()
        {
            //var database = client.GetDatabase("CarParkDB");

            //var jsonString = System.IO.File.ReadAllText("cities.json");

            //var cities = JsonConvert.DeserializeObject<List<cities>>(jsonString);

            //var citiesCollection = database.GetCollection<City>("City");
            //foreach (var item in cities)
            //{
            //    var city = new City()
            //    {
            //        Id = ObjectId.GenerateNewId(),
            //        Name = item.name,
            //        Plate = item.plate,
            //        Latitude = item.latitude,
            //        Logitude = item.longitude,
            //        Counties = new List<County>()
            //    };

            //    foreach (var item2 in item.counties)
            //    {
            //        city.Counties.Add(new County
            //        {
            //            Id = ObjectId.GenerateNewId(),
            //            Name = item2,
            //            Latitude = "",
            //            Longitude = "",
            //            PostCode = ""
            //        });
            //    }
            //    citiesCollection.InsertOne(city);
            //}
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult List()
        {
            return View();
        }
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
