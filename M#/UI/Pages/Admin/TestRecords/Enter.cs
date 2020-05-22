using MSharp;

namespace Admin.TestRecords
{
    class EnterPage : SubPage<TestRecordsPage>
    {
        public EnterPage()
        {
            Add<Modules.TestRecordForm>();
        }
    }
}