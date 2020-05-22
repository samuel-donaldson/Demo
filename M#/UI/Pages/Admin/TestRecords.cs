using MSharp;

namespace Admin
{
    class TestRecordsPage : SubPage<AdminPage>
    {
        public TestRecordsPage()
        {
            Set(PageSettings.LeftMenu, "AdminSettingsMenu");
            Add<Modules.TestRecordsLis>();
        }
    }
}
