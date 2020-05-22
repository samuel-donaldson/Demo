using MSharp;

namespace Admin.TestRecords
{
    class InputsPage : SubPage<Admin.TestRecordsPage>
    {
        public InputsPage()
        {
            Add<Modules.InputsList>();
        }
    }
}