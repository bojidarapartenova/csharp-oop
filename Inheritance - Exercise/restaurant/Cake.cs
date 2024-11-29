﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Cake : Dessert
    {
        private const double Grams = 250;
        private const double Calories = 1000;
        private const decimal Price = 5;
        public Cake(string name) : base(name, Price, Grams, Calories)
        {
            
        }
    }
}
