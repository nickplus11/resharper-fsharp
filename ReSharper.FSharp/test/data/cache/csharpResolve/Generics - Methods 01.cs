﻿using System;
using System.Collections.Generic;
using static Module;

namespace ClassLibrary1
{
    public class Class1
    {
        public Class1()
        {
            var t = new T<int>();
            Tuple<int, double> m = t.Method<double>();
        }
    }
}
