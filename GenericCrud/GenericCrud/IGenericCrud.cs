using System;
using System.Collections.Generic;

namespace GenericCrud
{
    public interface IGenericCrud<T> where T : class
    {
        void create(T oEntity);
        void delete(Func<T, bool> predicate);
        void update(T oEntity);
        IEnumerable<T> readAll();
        IEnumerable<T> read(Func<T, bool> predicate);
    }

}
