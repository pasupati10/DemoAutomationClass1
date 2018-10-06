using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Pages
{
    public class NewMenuItem : WpfMenuItem
    {
        WpfMenuItem newMenuItem;
        public NewMenuItem(UITestControl parent)
        {
            newMenuItem = new WpfMenuItem(parent);
            newMenuItem.SearchProperties.Add(WpfMenuItem.PropertyNames.Name, "New");
            newMenuItem.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
        }


        public void ClickonNewProject()
        {

            WpfMenuItem newProject = new WpfMenuItem(newMenuItem);
            newProject.SearchProperties.Add(WpfMenuItem.PropertyNames.Name, "Project...");
            newProject.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
            Mouse.Click(newProject);

        }
    }
}
