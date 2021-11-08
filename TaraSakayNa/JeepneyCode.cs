using System;
using System.Collections.Generic;
using System.Text;

namespace TaraSakayNa
{
    public class JeepneyCode
    {
        public JeepneyCode() { }

        public string Jcode { get; set; }
        public string Route { get; set; }
        public string ImageUrl { get; set; }

        public override string ToString()
        {
            return Jcode;
        }

    }

    
}
