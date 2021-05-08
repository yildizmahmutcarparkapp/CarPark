using CarPark.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CarPark.Core.Repository.Abstract
{
    public interface IRepository<TEntity> where TEntity : class, new()
    {
        GetManyResult<TEntity> GetAll();
        Task<GetManyResult<TEntity>> GetAllAsync();
        GetManyResult<TEntity> FilterBy(Expression<Func<TEntity, bool>> filter);
        Task<GetManyResult<TEntity>> FilterByAsync(Expression<Func<TEntity, bool>> filter);
        GetOneResult<TEntity> GetById(string id, string type = "object");
        Task<GetOneResult<TEntity>> GetByIdAsync(string id, string type="object");
        GetOneResult<TEntity> InsertOne(TEntity entity);
        Task<GetOneResult<TEntity>> InsertOneAsync(TEntity entity);
        GetManyResult<TEntity> InsertMany(ICollection<TEntity> entities);
        Task<GetManyResult<TEntity>> InsertManyAsync(ICollection<TEntity> entities);
        GetOneResult<TEntity> ReplaceOne(TEntity entity, string id, string type = "object");
        Task<GetOneResult<TEntity>> ReplaceOneAsync(TEntity entity, string id, string type = "object");
        GetOneResult<TEntity> DeleteOne(Expression<Func<TEntity, bool>> filter);
        Task<GetOneResult<TEntity>> DeleteOneAsync(Expression<Func<TEntity, bool>> filter);
        GetOneResult<TEntity> DeleteById(string id);
        Task<GetOneResult<TEntity>> DeleteByIdAsync(string id);
        void DeleteMany(Expression<Func<TEntity, bool>> filter);
        Task DeleteManyAsync(Expression<Func<TEntity, bool>> filter);

    }
}
