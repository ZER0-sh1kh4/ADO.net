using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    public class FlavourService
    {
        public string GetFlavour()
        {
            Console.WriteLine("Checking the flavour...");
            return "Vanilla Ice Cream";
        }
    }
}
