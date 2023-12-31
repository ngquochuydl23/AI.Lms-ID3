﻿namespace Lms_ID3_BE.Infrastructure.Repository
{
  public interface IRepository<TEntity>
  {
    TEntity Find(long? key);

    TEntity Insert(TEntity entity);

    TEntity[] InsertMany(TEntity[] entities);

    TEntity Update(long key, TEntity entity);

    void Delete(long key);

    void Delete(TEntity entity);

    void DeleteRange(TEntity[] entities);

    IQueryable<TEntity> GetQueryableNoTracking();

    IQueryable<TEntity> GetQueryable();

    ID3DatabaseContext DbContext();
  }
}
