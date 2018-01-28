using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_03_SavannahPyle
{
    class DeskQuote : Desk
    {
        Desk desk;

        public int rushDay;
        public int quote;
        public string Name { get; set; }
       

        public string SurfaceMaterial { get; set; }
        public int Rush { get; set; }

        public int CalculateRush()
        {
                

            return rushDay;
        }

        public int calculateQuote()
        {
           
            return quote;
        }


    }
}
