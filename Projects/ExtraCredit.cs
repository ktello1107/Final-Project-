using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projects
{
    public class ExtraCredit
    {
        
        public static int calculate(float numberofdays, float numberofabsences)
        {
           
                
                float percentage = numberofabsences/numberofdays;
                if (percentage >= 0.9)
                {
                    return 10;
                }

                else if (percentage >= 0.7 && percentage < 0.9)
                {
                    return 8;
                }

                else if (percentage >= 0.6 && percentage < 0.7)
                {
                    return 6;
                }

                else if (percentage > 0.5 && percentage < 0.6)
                {
                    return 2;
                }
                
                return 0;
             
        }
        


    }
}