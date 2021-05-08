using CarPar.Entities.Concrete;
using CarPark.Core.Models;
using CarPark.Models.ViewModels.Personels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarPark.Business.Abstract
{
    public interface IPersonelService
    {
        GetManyResult<Personel> GetPersonelsByAge();
        Task<GetOneResult<PersonelMainRole>> GetPersonelRoles(string id);
        Task<GetOneResult<Personel>> UpdatePersonelRoles(string personelId, string[] personelRoleList);
    }
}
