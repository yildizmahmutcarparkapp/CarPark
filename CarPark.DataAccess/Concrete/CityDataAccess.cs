using CarPar.Entities.Concrete;
using CarPark.Core.Settings;
using CarPark.DataAccess.Abstract;
using CarPark.DataAccess.Repository;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarPark.DataAccess.Concrete
{
    public class CityDataAccess : MongoRepositoryBase<City>, ICityDataAccess
    {
        public CityDataAccess(IOptions<MongoSettings> settings) : base(settings)
        {
        }
    }
}
