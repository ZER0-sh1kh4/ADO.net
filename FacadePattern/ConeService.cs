using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    public class ConeService
    {
        public string GetCone()
        {
            Console.WriteLine("Preparing the cone...");
            return "Cone";
        }
    }
}
