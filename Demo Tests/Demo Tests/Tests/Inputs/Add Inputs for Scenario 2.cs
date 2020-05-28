using Pangolin;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demo_Tests
{
    [TestClass]
    public class AddInputsForScenario2 : UITest
    {
        [TestMethod]
        public override void RunTest()
        {
            //add test
            Run<AddTestSTP8>();

            LoginAs<Admin>();

            Click("Tests");
            ExpectHeader("Test records");

            AtRow("STP 8").Column("Test description").Expect("(#02) Plate Bearing");
            AtRow("STP 8").Column("Test number	").Expect("101975.1.1.1");
            //navigate to inputs
            AtRow("STP 8").Column("Inputs").Click("0");

            ExpectHeader("Inputs");

            //add generic inputs
            Click("Add a new Generic Input");
            ExpectHeader("Input details");
            Set("Title").To("Location");
            ClickLabel("Generic");
            Click("Save");
            ExpectHeader("Inputs");
            ExpectRow("Location");

            Click("Add a new Generic Input");
            ExpectHeader("Input details");
            Set("Title").To("Lat");
            ClickLabel("Generic");
            Click("Save");
            ExpectHeader("Inputs");
            ExpectRow("Lat");

            Click("Add a new Generic Input");
            ExpectHeader("Input details");
            Set("Title").To("Lng");
            ClickLabel("Generic");
            Click("Save");
            ExpectHeader("Inputs");
            ExpectRow("Lng");

            Click("Add a new Generic Input");
            ExpectHeader("Input details");
            Set("Title").To("Date / Time");
            ClickLabel("Generic");
            Click("Save");
            ExpectHeader("Inputs");
            ExpectRow("Date / Time");

            Click("Add a new Generic Input");
            ExpectHeader("Input details");
            Set("Title").To("Material");
            ClickLabel("Generic");
            ClickLabel("Mandatory");
            Click("Save");
            ExpectHeader("Inputs");
            ExpectRow("Material");

            //add multi-selects
            Click("Add a new Multi Option Input");
            ExpectHeader("Input details");
            Set("Title").To("Weather Conditions");
            ClickLabel("Mandatory");
            Click("Add a new option");
            AtRow(1).SetXPath("//input[@type= 'text']").To("Sunny");
            Click("Add a new option");
            AtRow(2).SetXPath("//input[@type= 'text']").To("Rainy");
            Click("Add a new option");
            AtRow(3).SetXPath("//input[@type= 'text']").To("Snow");
            Click("Save");
            ExpectRow("Weather Conditions");

            Click("Add a new Multi Option Input");
            ExpectHeader("Input details");
            Set("Title").To("General ground condition");
            ClickLabel("Mandatory");
            Click("Add a new option");
            AtRow(1).SetXPath("//input[@type= 'text']").To("Dry");
            Click("Add a new option");
            AtRow(2).SetXPath("//input[@type= 'text']").To("Damp");
            Click("Add a new option");
            AtRow(3).SetXPath("//input[@type= 'text']").To("Wet");
            Click("Save");
            ExpectRow("General ground condition");

            Click("Add a new Generic Input");
            ExpectHeader("Input details");
            Set("Title").To("Air temperature");
            ClickLabel("Generic");
            ClickLabel("Mandatory");
            Set("Description").To("(celsius)");
            Click("Save");
            ExpectHeader("Inputs");
            ExpectRow("Air temperature");

            Click("Add a new Generic Input");
            ExpectHeader("Input details");
            Set("Title").To("Applied seating load");
            Set("Description").To("(bar)");
            ClickLabel("Generic");
            ClickLabel("Mandatory");
            Click("Save");
            ExpectHeader("Inputs");
            ExpectRow("Applied seating load");


            //add dynamic input
            Click("Add a new Dynamic Input");
            ExpectHeader("Input details");
            Set("Title").To("Table inputs");

            //add each field for dynamic input table
            Click("Add a new field");
            AtRow(1).Column("Group").Set().To("Gauge Reading");
            AtRow(1).Column("Name").Set().To("Jack gauge (bar)");
            
            //add fields for each column
            Click("Add a new field");
            AtRow(2).Column("Group").Set().To("Gauge Reading");
            AtRow(2).Column("Name").Set().To("Time (mins)");

            Click("Add a new field");
            AtRow(3).Column("Group").Set().To("Gauge Reading");
            AtRow(3).Column("Name").Set().To("1 (mm)");
            
            Click("Add a new field");
            AtRow(4).Column("Group").Set().To("Gauge Reading");
            AtRow(4).Column("Name").Set().To("2 (mm)");
            
            Click("Add a new field");
            AtRow(5).Column("Group").Set().To("Gauge Reading");
            AtRow(5).Column("Name").Set().To("3 (mm)");
            
            Click("Add a new field");
            AtRow(6).Column("Group").Set().To("Gauge Settlement");
            AtRow(6).Column("Name").Set().To("1(mm)");
            
            Click("Add a new field");
            AtRow(7).Column("Group").Set().To("Gauge Settlement");
            AtRow(7).Column("Name").Set().To("2(mm)");
            
            Click("Add a new field");
            AtRow(8).Column("Group").Set().To("Gauge Settlement");
            AtRow(8).Column("Name").Set().To("3(mm)");
            
            Click("Add a new field");
            AtRow(9).Column("Group").Set().To("Average");
            AtRow(9).Column("Name").Set().To("Settlement (mm)");

            Click("Save");
            
            ExpectRow("Table inputs");
            



        }
    }
}