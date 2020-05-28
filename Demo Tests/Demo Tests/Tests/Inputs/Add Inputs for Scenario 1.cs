using Pangolin;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demo_Tests
{
    [TestClass]
    public class AddInputsForScenario1 : UITest
    {
        [TestMethod]
        public override void RunTest()
        {
            //data for adding multiple inputs
            #region constants
            var Titles = new string[] { "Type of kentledge", "Plate diameter", "Plate ID", "Actual diameter of plate used", "Area of plate used", "Plate correction", "Jack ID", "Jack conversion value", "Dial gauge 1", "Dial gauge 2", "Dial guage 3", "Mass of plate", "Mass of jack", "Mass of spacer", "TOTAL MASS", "EQUIPMENT FORCE"};
            var Descriptions = new string[] { "", "Select the diameter plate to be used", "Unique Equipment ID of Plate to be used", "Actual diamteter of palte to be used 0dp", "Plate area", "", "Unique Equipmenrt ID of Jack to be used", "Jack conversion 3dp", "Serial No. of Dial Gauge 1", "Serial No. of Dial Gauge 2", "Serial No. Of Dial Gauge 3", "Mass of Plate in KG 2dp", "Mass of Jack in KG 2dp", "Mass of Space in KG 2dp", "Mass of Plate, Jack and Spacer in KG", "FOrce of equipment on ground Calc: (Total Mass*0.00981"};
            
            var Types = new string[] {"Generic", "Millimeter", "Generic", "Millimeter", "Meter", "Meter", "Generic", "Generic", "Generic", "Generic", "Generic", "Weight", "Weight", "Weight", "Weight", "Generic"};

            var Mandatories = new bool[] {true, true, true, true, false, false, true, true, true, true, true, true, true, false, false, false};
            #endregion

            //create test
            Run<AddTestSTP8>();

            LoginAs<Admin>();

            //navigate to input page
            Click("Tests");
            ExpectHeader("Test records");

            AtRow("STP 8").Column("Test description").Expect("(#02) Plate Bearing");
            AtRow("STP 8").Column("Test number	").Expect("101975.1.1.1");
            AtRow("STP 8").Column("Inputs").Click("0");

            ExpectHeader("Inputs");

            //add input using data 0
            Click("Add a new Generic Input");
            ExpectHeader("Input details");

            Set("Title").To(Titles[0]);
            Set("Description").To(Descriptions[0]);
            ClickLabel(Types[0]);
            ClickLabel("Mandatory");
            
            Click("Save");
            ExpectHeader("Inputs");

            ExpectRow(Titles[0]);


            //add multi-select using data 1
            Click("Add a new Multi Option Input");
            ExpectHeader("Input details");
            Set("Description").To(Descriptions[1]);
            Set("Title").To(Titles[1]);
            ClickLabel("Mandatory");
            Click("Add a new option");
            AtRow(1).SetXPath("//input[@type= 'text']").To("600");
            Click("Add a new option");
            AtRow(2).SetXPath("//input[@type= 'text']").To("300");
            Click("Add a new option");
            AtRow(3).SetXPath("//input[@type= 'text']").To("55");
            Click("Save");
            ExpectRow(Titles[1]);


            //add inputs for rest of test data
            for (int i = 2; i < Titles.Length; i++)
            {
                Click("Add a new Generic Input");
                ExpectHeader("Input details");

                Set("Title").To(Titles[i]);
                Set("Description").To(Descriptions[i]);
                ClickLabel(Types[i]);

                if (Mandatories[i])
                {
                    ClickLabel("Mandatory");

                }
                Click("Save");
                ExpectHeader("Inputs");

                ExpectRow(Titles[i]);
            }
        }
    }
}