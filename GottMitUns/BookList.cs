﻿using System;

namespace Generics
{
    public class BookList
    {
        public void Add(Book Book)
        {
            throw new NotImplementedException();
        }

        public Book this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    public class GenericDictionary<Tkey, TValue>
    {
        public void Add(Tkey key, TValue value)
        {

        }
    }
    public class GenericList<T>
    {
        public void Add(T value)
        {

        }
        public T this[int index]
        {
            get { throw new NotImplementedException();  }
        }
    }
}
