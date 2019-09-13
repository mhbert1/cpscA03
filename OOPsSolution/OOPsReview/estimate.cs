using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview
{
    public class estimate
    {
        public double TotalPrice { get; set; }

        public double LinearLength { get; set; }

        public FencePanel Panel { get; set; }

        public List<Gate> Gates { get; set; }

        public double CalculatePrice()
        {
            double numberofpanels = Panel.EstimatedNumberOfPanels(LinearLength);
            if ((int)(numberofpanels * 10.0) > ((int)numberofpanels * 10))
            {
                numberofpanels = (int)numberofpanels + 1;
            }
            if (Panel.Price ==null)
            {
                throw new Exception("panel price is needed to create estimate");
            }
            else
            {
                TotalPrice += numberofpanels * (double)Panel.Price;
                foreach(var item in Gates)
                {
                    TotalPrice += item.Price;
                    return TotalPrice;
                }
            }
        }
    }
}
