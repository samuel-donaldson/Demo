using Pangolin;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demo_Tests
{
    [TestClass]
    public class AddTestSTP8 : UITest
    {
        [TestMethod]
        public override void RunTest()
        {
            LoginAs<Admin>();

            //navigate to tests
            Click("Tests");
            ExpectHeader("Test records");
            
            Click("New Test Record");
            ExpectHeader("Test record details");

            //add test
            Set("Title").To("STP 8");
            Set("Test description").To("(#02) Plate Bearing");
            Set("Test number").To("101975.1.1.1");
            Set("Procedure").To("Estimation of California Bearing Ratio (Plate Bearing)");

            Click("Save");

            ExpectHeader("Test records");
            ExpectRow("STP 8");

            //expect data to appear in table
            AtRow("STP 8").Column("Test description").Expect("(#02) Plate Bearing");
            AtRow("STP 8").Column("Test number").Expect("101975.1.1.1");
            AtRow("STP 8").Column("Inputs").Expect("0");
        }
    }
}