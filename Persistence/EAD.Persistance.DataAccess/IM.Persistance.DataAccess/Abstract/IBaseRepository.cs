namespace IM.Persistance.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    public interface IBaseRepository<T> where T : class, IEntityBase, new()
    {
        IEnumerable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties);
        IEnumerable<T> GetAll();
        int Count();
        T GetById(int id);

        T GetSingle(Expression<Func<T, bool>> predicate);
        T GetSingle(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
        IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate);
        IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);


        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void DeleteWhere(Expression<Func<T, bool>> predicate);       
        void Commit();

    }
}
