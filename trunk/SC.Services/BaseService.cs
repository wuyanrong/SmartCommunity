﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SC.Services
{
    public class BaseService<T> where T : new()
    {
        private static T _instance = new T();

        public static T Instance
        {
            get { return _instance; }
        }
    }
}
