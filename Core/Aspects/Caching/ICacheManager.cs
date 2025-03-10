﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Aspects.Caching
{
    public interface ICacheManager
    {
        void Add(string key, object value, int duration);

        object Get(string key);

        T Get<T>(string key);

        bool IsAdd(string key);

        void Remove(string key);

        void RemoveByPattern(string pattern);


    }
}
