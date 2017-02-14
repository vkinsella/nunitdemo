using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitDemo
{
    public class Postage
    {
        static void Main()
        {  }
 	public int GetRegionCost(int region)
 	{
 	        switch(region)
                {
 			        case 1: return 10;
 			        case 2: return 15;
 			        case 3: return 20;
 			        case 4: return 25;
 			        default: return 0;
 	           }
            }

         public double GetPostageCost(int region, double parcelWeight)
         {
 	        return parcelWeight* 0.05 + GetRegionCost(region);
         }

    }
}
