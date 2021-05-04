using CarPar.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarPark.Models.ViewModels.Personels
{
    public class PersonelProfileInfo
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string CityName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public bool ReceiveNotification { get; set; }
        public bool ReceiveMessage { get; set; }
        public IFormFile Image { get; set; }
        public string ImageUrl { get; set; }
        public IEnumerable<City> Cities { get; set; }
    }
}
