﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IceCreamShop
{
    public class ConeComparer : IComparer<Cone>
    {
        public int Compare(Cone x, Cone y)
        {
            //return double.Compare(x.Cost, y.Cost);

            if(x.Cost - y.Cost > 0)
            {
                return 1;
            }
            else if (x.Cost - y.Cost < 0)

            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
