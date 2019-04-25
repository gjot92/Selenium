using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Exam
{
    public class ItemPrice
    {
        private double wholesalePrice;

        public ItemPrice(double WholesaleCost)
        {
            WholesalePrice = WholesaleCost;
        }

        public double WholesalePrice
        {
            get
            {
                return wholesalePrice;
            }

            set
            {
                if(value > 0)
                {
                    wholesalePrice=value;
                }
            }
        }

    }
}
