using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projects
{
    public class ExtraCredit
    {
        public string studentfirstName { get; set;}
        public string studentlastName { get; set;}
        public int calculate {
            get 
            {
                int counter = 0;
                foreach(String attendance in history)  {

                }
                float percentage = counter / history.Count;
                if (percentage >= 0.9)
                {
                    return 10;
                }
                return 0;
            } 
        }
        public List<String> history { get; set; }


    }
}