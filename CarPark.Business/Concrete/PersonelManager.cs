using AspNetCore.Identity.MongoDbCore.Models;
using CarPar.Entities.Concrete;
using CarPark.Business.Abstract;
using CarPark.Core.Models;
using CarPark.DataAccess.Abstract;
using CarPark.Models.ViewModels.Personels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark.Business.Concrete
{
    public class PersonelManager : IPersonelService
    {
        private readonly IPersonelDataAccess _personelDataAccess;
        private readonly RoleManager<MongoIdentityRole> _roleManager;

        public PersonelManager(IPersonelDataAccess personelDataAccess, RoleManager<MongoIdentityRole> roleManager)
        {
            _personelDataAccess = personelDataAccess;
            _roleManager = roleManager;
        }

        public async Task<GetOneResult<PersonelMainRole>> GetPersonelRoles(string id)
        {
            var result = new GetOneResult<PersonelMainRole>();

            try
            {
                var roles = _roleManager.Roles != null ? _roleManager.Roles.ToList() : null;

                var personel = await _personelDataAccess.GetByIdAsync(id, "guid");

                var personelRoles = personel != null && personel.Entity != null
                    && personel.Entity.Roles != null ?
                    personel.Entity.Roles.Select(x => new PersonelRoles
                    {
                        Id = x.ToString(),
                        Name = roles.FirstOrDefault(y => y.Id == x).Name
                    }).ToList() : null;

                result.Entity = new PersonelMainRole
                {
                    Roles = roles,
                    PersonelRoleList = personelRoles
                };
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Entity = null;
                result.Success = false;
            }
            return result;
        }

        public GetManyResult<Personel> GetPersonelsByAge()
        {
            var personelList = _personelDataAccess.GetAll();
            return personelList;
        }

        public async Task<GetOneResult<Personel>> UpdatePersonelRoles(string personelId, string[] personelRoleList)
        {
            var personel = await _personelDataAccess.GetByIdAsync(personelId, "guid");

            var roles = personelRoleList.Select(x => new Guid(x)).ToList();

            personel.Entity.Roles = null;
            personel.Entity.Roles = roles;

            var result = await _personelDataAccess.ReplaceOneAsync(personel.Entity, personelId, "guid");
            result.Message = $"{personel.Entity.Name} {personel.Entity.Surname} adlı personelin rol güncellemesi gerçekleşti.";

            return result;
        }
    }
}
