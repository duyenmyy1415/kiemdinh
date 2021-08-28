using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using PhanMemQLNhaSach;

namespace CodedUITestProject_Code
{

    [CodedUITest]
    public class CodedUITest_PhanMemQLNhaSach
    {
        public CodedUITest_PhanMemQLNhaSach()
        {
        }

        [TestMethod]
        [TestCategory("Passed")]
        public void TC1_TestAddSach()
        {
            this.UIMap.RecordedMethod_AddSachCode();
        }

        [TestMethod]
        [TestCategory("Passed")]
        public void TC2_TestEditSach()
        {
            this.UIMap.RecordedMethod_EditSach();
        }

        [TestMethod]
        [TestCategory("Passed")]
        public void TC3_TestDeleteSach()
        {
            this.UIMap.RecordedMethod_DeleteSachCode();
            //this.UIMap.RecordedMethod_DeleteSach();
        }

        [TestMethod]
        [TestCategory("Passed")]
        public void TC4_TestFindSach()
        {
            this.UIMap.RecordedMethod_FindSach();
        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

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

        public UIMap UIMap
        {
            get
            {
                if ((this.map == null))
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
