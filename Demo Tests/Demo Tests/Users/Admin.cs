using Pangolin;

namespace Demo_Tests
{
    public class Admin : UITest
    {
        public override void RunTest()
        {
            Logout();

            AssumeDate("01/07/2020");
            AssumeTime("13:00");

            Goto("/");

            Set("Email").To("admin@uat.co");
            Set("Password").To("test");
            Click("Login");
            Expect("Logout");
        }
    }
}