using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Shared
{
    public static class Units
    {
        public static Unit Grams = new() { Name = "Grams", Abbreviation = "g" };
        public static Unit Milliliters = new() { Name = "Milliliters", Abbreviation = "ml" };
        public static Unit Pieces = new() { Name = "Pieces", Abbreviation = "pcs" };
    }
}
