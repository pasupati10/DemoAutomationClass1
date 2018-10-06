using ApplicationLayer.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer
{
    public static class PageControl
    {
     
        public static VSMainWindow MainWindow
        {
            get
            {
               
                return new VSMainWindow();
            }
        }
    }
}
