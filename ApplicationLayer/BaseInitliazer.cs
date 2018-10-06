using Microsoft.VisualStudio.TestTools.UITesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer
{
   public class BaseInitliazer:ParentWindow
    {
        
        public void LaunchApplication(string path)
        {
             AUT = ApplicationUnderTest.Launch(path);
        }

        public void CloseApplication()
        {
            AUT.Close();
        }

    }
}
