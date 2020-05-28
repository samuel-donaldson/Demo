using Pangolin;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demo_Tests
{
    [TestClass]
    public class FailureExample : UITest
    {
        [TestMethod]
        public override void RunTest()
        {
            Run<AddInputsForScenario2>();

            LoginAs<Admin>();

            Click("Tests");
            ExpectHeader("Test records");

            AtRow("STP 8").Column("Test description").Expect("(#02) Plate Bearing");
            AtRow("STP 8").Column("Test number	").Expect("101975.1.1.1");
            AtRow("STP 8").Column("Inputs").Click("10");

            ExpectHeader("Inputs");

            //lng should appear as a row after being added in pre-condition
            //anticipate a failure
            ExpectNoRow("Lng");
        }
    }
}