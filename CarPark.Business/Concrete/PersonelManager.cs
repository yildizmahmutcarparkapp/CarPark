using CarPar.Entities.Concrete;
using CarPark.Business.Abstract;
using CarPark.Core.Models;
using CarPark.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarPark.Business.Concrete
{
    public class PersonelManager : IPersonelService
    {
        private readonly IPersonelDataAccess _personelDataAccess;

        public PersonelManager(IPersonelDataAccess personelDataAccess)
        {
            _personelDataAccess = personelDataAccess;
        }

        public GetManyResult<Personel> GetPersonelsByAge()
        {
            var personelList = _personelDataAccess.GetAll();

            /////
            /////
            ///bazı işlemler yaptım
            ///
            ///

            return personelList;
        }
    }
}
