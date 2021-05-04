using CarPar.Entities.Concrete;
using CarPark.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarPark.Business.Abstract
{
    public interface IPersonelService
    {
        GetManyResult<Personel> GetPersonelsByAge();
    }
}
