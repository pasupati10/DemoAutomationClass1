using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer
{
   public class ParentWindow:WinControl
    {
      public ApplicationUnderTest AUT
        {
            get;set;
        }

        public BrowserWindow BrowserWindow { get; set; }

    }
}
