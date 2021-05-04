using AutoMapper;
using CarPar.Entities.Concrete;
using CarPark.Business.Abstract;
using CarPark.Models.ViewModels.Personels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;

namespace CarPark.User.Controllers
{
    [Authorize(Roles = "admin")]
    public class PersonelsController : Controller
    {
        private readonly IPersonelService _personelService;
        private readonly ICityService _cityService;
        private readonly IMapper _mapper;
        private readonly UserManager<Personel> _userManager;
        private readonly IWebHostEnvironment _env;

        public PersonelsController(IPersonelService personelService,
            IMapper mapper,
            IWebHostEnvironment env,
            ICityService cityService,
            UserManager<Personel> userManager)
        {
            _personelService = personelService;
            _userManager = userManager;
            _cityService = cityService;
            _mapper = mapper;
            _env = env;
        }
        public IActionResult GetPersonelsByAge()
        {
            var result = _personelService.GetPersonelsByAge();

            return View(result);
        }
        public async Task<IActionResult> Settings()
        {
            var user = await _userManager.GetUserAsync(User);
            var cities = await _cityService.GetAllCitiesAsync();
            user.ImageUrl = $"/Media/Personels/{user.ImageUrl}";
            var personelInfo = _mapper.Map<PersonelProfileInfo>(user);
            personelInfo.Cities = cities.Result;
            return View(personelInfo);
        }
        [HttpPost]
        public async Task<IActionResult> Settings(PersonelProfileInfo personelInfo)
        {
            var user = _userManager.GetUserAsync(User).Result;
            string imgUrl = "";
            if (personelInfo.Image != null && personelInfo.Image.Length > 0)
            {
                var path = Path.Combine(_env.WebRootPath, "Media/Personels/");
                var fileName = Guid.NewGuid().ToString() + "_" + personelInfo.Image.FileName;

                var filePath = Path.Combine(path, fileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    personelInfo.Image.CopyTo(fileStream);
                    imgUrl = fileName;
                }
            }
            else
            {
                imgUrl = user.ImageUrl;
            }
            personelInfo.UserName = user.UserName;
            personelInfo.Email = user.Email;
            personelInfo.ImageUrl = imgUrl;

            var personel = _mapper.Map(personelInfo, user);
            var updated = await _userManager.UpdateAsync(personel);
            if (updated.Succeeded)
                return Json(new { message = "Başarılı", success = true, personel = personel });
            else
                return Json(new { message = "Başarısız", success = false, personel = personel });
        }
    }
}
