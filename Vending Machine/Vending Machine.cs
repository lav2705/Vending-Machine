using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine_name
{
    public class Vending_Machine
    {
        IDictionary<string, double> producttoprice = new Dictionary<string, double>();
        double currentinsertedvalue;
        public void insertproduct(string productname, double val)
        {
            producttoprice.Add(productname, val);
        }
        public double getcurrentvalue()
        {
            return currentinsertedvalue;
        }
        public void insertcoin(double coinval )
        {
            currentinsertedvalue = currentinsertedvalue + coinval;
}
        public void reset()
        {
            currentinsertedvalue = 0;
        }

    }

    enum Coins
    {
        penny=1,
        Nickel=2,
        dimes=3,
        quarter=4
    }
}


