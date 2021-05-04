using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarPar.Entities.Concrete;
using CarPark.Core.Repository.Abstract;
using CarPark.User.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace CarPark.User.Controllers
{
    public class UserController : Controller
    {
        private readonly IStringLocalizer<UserController> _localizer;
        private readonly IRepository<Personel> _personelRepository;
        public UserController(IStringLocalizer<UserController> localizer, IRepository<Personel> personelRepository)
        {
            _localizer = localizer;
            _personelRepository = personelRepository;
        }
        public IActionResult Index()
        {

            var nameSurnameValue = _localizer["NameSurname"];
            return View();
        }

        public IActionResult Create()
        {

            //var result = _personelRepository.InsertOne(new Personel
            //{
            //    Email = "yldzmahmut0@gmail.com",
            //    Password = "12345",
            //    CreatedDate = DateTime.Now,
            //    UserName = "yldzmahmut"
            //});
            //var result2 = _personelRepository.InsertOneAsync(new Personel
            //{
            //    Email = "yldzmahmut1@gmail.com",
            //    Password = "123456",
            //    CreatedDate = DateTime.Now,
            //    UserName = "yldzmahmut1"
            //});

            //var result3 = _personelRepository.InsertMany(new List<Personel>
            //{
            //    new Personel
            //    {
            //    Email = "yldzmahmut2@gmail.com",
            //    Password = "123456",
            //    CreatedDate = DateTime.Now,
            //    UserName = "yldzmahmut1"
            //        },
            //    new Personel
            //    {
            //    Email = "yldzmahmut3@gmail.com",
            //    Password = "123456",
            //    CreatedDate = DateTime.Now,
            //    UserName = "yldzmahmut3"
            //        }
            //}
            //);

            //var result4 = _personelRepository.AsQueryable();


            //var result5 = _personelRepository.GetById("6027c48d4e5aa3ad1aaa30d1");

            //var result6 = _personelRepository.DeleteOne(x => x.Email.Contains("ut2"));
            var result6 = _personelRepository.GetById("6027c3e25b0aaba4b8277ba7");
            result6.Entity.Email = "mahmut@gmail.com";
            //result6.Entity.Password = "123451231234";
            result6.Entity.UserName = "mahmut";
            var result7 = _personelRepository.ReplaceOne(result6.Entity, result6.Entity.Id.ToString());
























            return View();
        }
        [HttpPost]
        public IActionResult Create(UserCreateRequestModel request)
        {
            return View(request);
        }
    }
}