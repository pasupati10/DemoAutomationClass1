using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using System.Windows.Automation;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using ApplicationLayer;
using ApplicationLayer.Pages;

namespace demoCodedUI
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1: BaseInitliazer
    {

        [TestMethod]
        public void TestApplication()
        {
            //obj1
            //obj2           
            PageControl.MainWindow.ClickCreateCRF();
            PageControl.MainWindow.CRFMainWindow.UploadFile("asdfas");
                
        }
        public CodedUITest1()
        {
        }

        [TestMethod]        
        public void CodedUITestMethod1()
        {
            int value = 1;
            BrowserWindow window = BrowserWindow.Launch("http://automationpractice.com/index.php");
            Thread.Sleep(3000);
            HtmlDiv dresslinkParent = new HtmlDiv(window);
            dresslinkParent.SearchProperties.Add(HtmlDiv.PropertyNames.Id, "block_top_menu");
            //dresslinkParent.DrawHighlight();
            HtmlHyperlink DressesLink = new HtmlHyperlink(dresslinkParent);
            //DressesLink.SearchProperties.Add(HtmlHyperlink.PropertyNames.TagName, "A");
            DressesLink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Dresses";
            //this.mUIDressesHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/index.php";
            //this.mUIDressesHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = "Dresses";
            DressesLink.SearchProperties.Add(HtmlHyperlink.PropertyNames.Title, "Dresses");
            var col = DressesLink.FindMatchingControls();
            //col[1].DrawHighlight();
            Mouse.Hover(col[1]);
            Thread.Sleep(1000);
            HtmlHyperlink summerDresses = new HtmlHyperlink(dresslinkParent);
            summerDresses.SearchProperties.Add(HtmlHyperlink.PropertyNames.TagName, "A");
            summerDresses.SearchProperties.Add(HtmlHyperlink.PropertyNames.InnerText, "Summer Dresses".ToUpper());
            col = summerDresses.FindMatchingControls();
            //col[0].DrawHighlight();
            //col[1].DrawHighlight();
            Mouse.Click(col[1]);

            HtmlCheckBox checkbog = new HtmlCheckBox(window);
            checkbog.SearchProperties.Add(HtmlCheckBox.PropertyNames.Id, "layered_id_attribute_group_1");
            if(checkbog.Checked==false)
            {
                checkbog.Checked = true;
            }
            

            HtmlComboBox combobo = new HtmlComboBox();
            combobo.SelectedItem = "value";
            HtmlRadioButton butt =new HtmlRadioButton();
            butt.Selected = false;
            butt.WaitForControlEnabled();
               






        }


        [TestMethod]
        public void TestMethod1()
        {

            this.UIMap.opennewproject();

            this.UIMap.SelecttheProject();
            this.UIMap.RecordedMethod1();


            this.UIMap.RecordedMethod3();
            this.UIMap.RecordedMethod4();


        }

        [TestMethod]
        public void AutomateVS()
        {
            //ApplicationUnderTest app = ApplicationUnderTest.Launch(@"C:\Program Files (x86)\Microsoft Visual Studio 14.0\Common7\IDE\devenv.exe");
            WinWindow mainwindow = new WinWindow();
            mainwindow.SearchProperties.Add(WinWindow.PropertyNames.Name, "Start Page - Microsoft Visual Studio");
            WinMenuBar mainmenubar = new WinMenuBar(mainwindow);

            //mainmenubar.SearchProperties.Add(WinMenuBar.PropertyNames.Name, "MenuBar");
            //WinMenuItem filemenuitem = new WinMenuItem(mainmenubar);
            //filemenuitem.SearchProperties.Add(WinMenuItem.PropertyNames.Name, "File");
            //Mouse.Click(filemenuitem);
            //Thread.Sleep(1000);

            //WpfMenuItem newMenuItem = new WpfMenuItem(filemenuitem);
            //newMenuItem.SearchProperties.Add(WpfMenuItem.PropertyNames.Name, "New");
            //newMenuItem.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
            ////Mouse.Hover(newMenuItem);

            //WpfMenuItem newProject = new WpfMenuItem(newMenuItem);
            //newProject.SearchProperties.Add(WpfMenuItem.PropertyNames.Name, "Project...");
            //newProject.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
            //Mouse.Click(newProject);

            //WpfWindow newprojectwindow = new WpfWindow(mainwindow);
            //newprojectwindow.SearchProperties.Add(WinWindow.PropertyNames.Name, "New Project");
            //newprojectwindow.DrawHighlight();
            //WpfControl installedDatagrid = new WpfControl(newprojectwindow);

            //installedDatagrid.SearchProperties[WpfControl.PropertyNames.ControlType] = "DataItem";
            //installedDatagrid.SearchProperties[WpfControl.PropertyNames.AutomationId] = "Installed";
            //WpfExpander expand = new WpfExpander(installedDatagrid);
            //WpfTree installedTreeView = new WpfTree(expand);
            //installedTreeView.SearchProperties.Add(WpfTree.PropertyNames.AutomationId, "Installed");           

            ////installedTreeView.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
            //installedTreeView.DrawHighlight();
            //WpfTreeItem tempTreeItem = new WpfTreeItem(installedTreeView);
            //tempTreeItem.SearchProperties.Add(WpfTreeItem.PropertyNames.AutomationId, "Templates");
            ////tempTreeItem.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
            //tempTreeItem.DrawHighlight();

            //WpfTreeItem visualCtreeItem = new WpfTreeItem(tempTreeItem);
            //visualCtreeItem.SearchProperties.Add(WpfTreeItem.PropertyNames.AutomationId, "Visual C#");
            ////visualCtreeItem.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
            //visualCtreeItem.DrawHighlight();
            //expand.Expanded = true;
            //WpfTreeItem testTreeItem = new WpfTreeItem(visualCtreeItem);

            //testTreeItem.SearchProperties.Add(WpfTreeItem.PropertyNames.AutomationId, "Test");
            ////testTreeItem.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
            //testTreeItem.DrawHighlight();

            //Mouse.Click(testTreeItem);

            //WpfButton okbutton = new WpfButton(newprojectwindow);
            //okbutton.SearchProperties.Add(WpfButton.PropertyNames.Name, "OK");
            //Mouse.Click(okbutton);

            WpfWindow MainWindow1 = new WpfWindow();
            MainWindow1.SearchProperties.Add(WinWindow.PropertyNames.Name, "CodedUITestProject6 - Microsoft Visual Studio");

            MainWindow1.DrawHighlight();


            WinWindow Generatetest = new WinWindow();
            Generatetest.SearchProperties.Add(WinWindow.PropertyNames.Name, "Generate Code for Coded UI Test");
            // Generatetest.SearchProperties.Add(WinWindow.PropertyNames.ClassName, "Generate Code for Coded UI Test");
            //"WindowsForms10.Window", PropertyExpressionOperator.Contains


            // WpfButton OkButton = new WpfButton(Generatetest);
            // OkButton.SearchProperties.Add(WpfButton.PropertyNames.AutomationId, "CancelButton");


            //// this.UIMap.RecordedMethod2();
            // Mouse.Click(OkButton);


            WpfButton TestExplorerTab = new WpfButton(MainWindow1);
          //  TestExplorerTab.SearchProperties.Add(WpfButton.PropertyNames.AutomationId, "Text");
            TestExplorerTab.SearchProperties.Add(WpfButton.PropertyNames.Name, "Test Explorer");           
           // TestExplorerTab.DrawHighlight();
           // Mouse.Click(TestExplorerTab);

            WpfPane TextExplorerpane = new WpfPane(MainWindow1);
            TextExplorerpane.SearchProperties.Add(WpfControl.PropertyNames.AutomationId, "PART_HwndHost");
            //TextExplorerpane.SearchProperties[WpfControl.PropertyNames.ClassName] = "Uia.SearchControl";
            // TextExplorerpane.SearchProperties.Add(WpfControl.PropertyNames.Name, "Test Explorer");
            //var controls=TextExplorerpane.FindMatchingControls();

            //TextExplorerpane.DrawHighlight();
            WpfCustom customsearch = new WpfCustom(TextExplorerpane);
            customsearch.SearchProperties.Add(WpfCustom.PropertyNames.AutomationId, "SearchControl");

            WpfText TestExplorerSearchText = new WpfText(customsearch);
            //TestExplorerSearchText.SearchProperties.Add(WpfText.PropertyNames.AutomationId, "PART_SearchBox");
            var controls = TestExplorerSearchText.FindMatchingControls();
            TestExplorerSearchText.DrawHighlight();
            Mouse.Click(TestExplorerSearchText);

        }


        public void TestMethod2()
        {
            ApplicationUnderTest window = ApplicationUnderTest.Launch(@"C:\Users\pmallika\Desktop\CRFFileCreation\TestDataCreation.exe");
            window.SearchProperties.Add(WinWindow.PropertyNames.Name, "Form1");
            WinButton button = new WinButton(window);
            button.SearchProperties.Add(WinButton.PropertyNames.Name, "Create CRF");
            button.DrawHighlight();
            Mouse.Click(button);

           

           

        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        [TestInitialize()]
        public void MyTestInitialize()
        {
            LaunchApplication(@"C:\Program Files(x86)\Microsoft Visual Studio 14.0\Common7\IDE\devenv.exe");
        }

        ////Use TestCleanup to run code after each test has run
        [TestCleanup()]
        public void MyTestCleanup()
        {
            TestContext.WriteLine("this is test clean pup");
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        }

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        private string _name;
        public string Propertytype {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }


        public UIMap UIMap
        {
            get
            {

                map = new UIMap();
                return map;
            }
        }

        private UIMap map;
    }
}
