using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.DataAccess
{
    //generic constraint
    //:class ile T referans tip olmalı şartı koyuldu.
    //IEntity ile IEntity olabilir ya da IEntity den implement edilen bir nesne olabilir.
    //new() : new'lenebilir olmalı şartı koyuldu. (yani artık IEntity veremeyiz demek)

    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        //Linq ile sorgulama yapıp istediğimiz şekilde veri çekmemizi sağlar
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
