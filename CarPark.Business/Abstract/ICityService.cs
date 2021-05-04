using CarPar.Entities.Concrete;
using CarPark.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarPark.Business.Abstract
{
    public interface ICityService
    {
        Task<GetManyResult<City>> GetAllCitiesAsync();
    }
}
