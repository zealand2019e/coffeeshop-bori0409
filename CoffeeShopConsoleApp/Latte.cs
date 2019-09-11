﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class Latte : Coffee, IMilk
    {
        public int mlMilk()
        {
            return 200;
        }

        public override string Name()
        {
            return "Latte";
        }

        public override int price()
        {
            return 40;
        }

        public override string Strength()
        {
            return "Wesk";
        }
    }
}
