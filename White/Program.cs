using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.WindowStripControls;
using NUnit.Framework;
using NUnit;

namespace WhiteLib
{
    [TestFixture]
    public class Sample2
    {
        static void Main() { }

        [Test]
        public void TestMethod()
        {
            Application app = null;
            try
            {

                app = Application.Launch("TestWPF.exe");
                Window window = app.GetWindow("MainWindow");

                var button = window.Get<Button>("btnOK");
                button.Click();

                Assert.AreEqual(window.Enabled, true);
            }
            finally
            {
                app.Close();
            }
        }
    }
}