using CarPar.Entities.Concrete;
using CarPark.Core.Settings;
using CarPark.DataAccess.Abstract;
using CarPark.DataAccess.Context;
using CarPark.DataAccess.Repository;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarPark.DataAccess.Concrete
{
    public class PersonelDataAccess : MongoRepositoryBase<Personel>, IPersonelDataAccess
    {
        private readonly MongoDbContext _context;
        private readonly IMongoCollection<Personel> _collection;
        public PersonelDataAccess(IOptions<MongoSettings> settings) : base(settings)
        {
            _context = new MongoDbContext(settings);
            _collection = _context.GetCollection<Personel>();
        }
       
    }
}
