using System;
using System.Collections.Generic;
using System.Text;

namespace Cities.Comparers
{
    class CompoundComparer : IComparer<City>
    {
        public IList<IComparer<City>> Comparers { get; set; }
        public CompoundComparer()
        {
            Comparers = new List<IComparer<City>>();
        }
        public int Compare(City x, City y)
        {
            while (Comparers[0].Compare(x, y) != 0)
            {
                return Comparers[0].Compare(x, y);
            }
            return Comparers[1].Compare(x, y);
        }
    }
}
