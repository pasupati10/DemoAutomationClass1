using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Pages
{
   public class VsMenuBar:WinMenuBar
    {
        WinMenuBar menubar;
        public VsMenuBar(UITestControl parentWindow)
        {
            menubar = new WinMenuBar(parentWindow);
            menubar.SearchProperties.Add(WinMenuBar.PropertyNames.Name, "MenuBar");

        }

     
       public FileMenuItem FileMenuItem {
            get
            {
                               
                return new FileMenuItem(menubar);                   
              
            }
        }

       
       

    }
}
