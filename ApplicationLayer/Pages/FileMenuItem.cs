using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Pages
{
   public class FileMenuItem:WinMenuItem
    {
        WinMenuItem _fileMenuItem;
        public FileMenuItem(UITestControl parentWindow)
        {
           
            _fileMenuItem = new WinMenuItem(parentWindow);
            _fileMenuItem.SearchProperties.Add(WinMenuItem.PropertyNames.Name, "File");
            
            
        }

        public NewMenuItem NewMeuItem
        {
            get { return new  NewMenuItem(_fileMenuItem); }
        }

        public void SaveAll()
        {

        }
    }
}
