﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cities.Comparers
{
    class AreaComparer:IComparer<City>
    {
        public int Compare(City x, City y)
        {
            return y.Area.CompareTo(x.Area);
        }
    }
}
