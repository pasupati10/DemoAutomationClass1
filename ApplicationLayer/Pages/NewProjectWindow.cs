using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Pages
{
    public class NewProjectWindow:WpfWindow
    {
        WpfWindow newprojectwindow;

       public NewProjectWindow(UITestControl parent)
        {
            newprojectwindow = new WpfWindow(parent);
            newprojectwindow.SearchProperties.Add(WpfWindow.PropertyNames.Name, "New Project");
            newprojectwindow.DrawHighlight();
          
        }

        public void ClickOnCreateNewTestClass()
        {
            WpfControl installedDatagrid = new WpfControl(newprojectwindow);

            installedDatagrid.SearchProperties[WpfControl.PropertyNames.ControlType] = "DataItem";
            installedDatagrid.SearchProperties[WpfControl.PropertyNames.AutomationId] = "Installed";

            WpfExpander expand = new WpfExpander(installedDatagrid);
            WpfTree installedTreeView = new WpfTree(expand);
            installedTreeView.SearchProperties.Add(WpfTree.PropertyNames.AutomationId, "Installed");

            WpfTreeItem tempTreeItem = new WpfTreeItem(installedTreeView);
            tempTreeItem.SearchProperties.Add(WpfTreeItem.PropertyNames.AutomationId, "Templates");
          
            WpfTreeItem visualCtreeItem = new WpfTreeItem(tempTreeItem);
            visualCtreeItem.SearchProperties.Add(WpfTreeItem.PropertyNames.AutomationId, "Visual C#");
            expand.Expanded = true;

            WpfTreeItem testTreeItem = new WpfTreeItem(visualCtreeItem);
            testTreeItem.SearchProperties.Add(WpfTreeItem.PropertyNames.AutomationId, "Test");
          
            Mouse.Click(testTreeItem);
        }

        }
}
