using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class BlackCoffe : Coffee
    {
        

        public override int price()
        {
            return 20;
        }

        public override string Strength()
        {
            return "Strong";
        }
    }
}
