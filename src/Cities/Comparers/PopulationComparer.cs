using System;
using System.Collections.Generic;
using System.Text;

namespace Cities.Comparers
{
    class PopulationComparer:IComparer<City>
    {
        public int Compare(City x, City y)
        {
                return y.Population.CompareTo(x.Population);
        }
    }
}
