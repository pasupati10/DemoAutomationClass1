using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ApplicationLayer.Pages
{
    public class VSMainWindow:WinWindow
    {

        WinWindow mainwindow;
        public VSMainWindow()
        {
            mainwindow = new WinWindow();
            mainwindow.SearchProperties.Add(WinWindow.PropertyNames.Name, "Start Page - Microsoft Visual Studio");
            Thread.Sleep(3000);
        }


        public VsMenuBar MenuBar
        {
            get
            {
                return new VsMenuBar(mainwindow);
            }


        }

        public NewProjectWindow NewProjectWindow
        {
            get
            {
                return new NewProjectWindow(mainwindow);
            }


        }

    }
}
