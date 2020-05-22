using MSharp;

namespace Modules
{
    class TestRecordForm : FormModule<Domain.TestRecord>
    {
        public TestRecordForm()
        {
            // TODO: Configure me ...!
            HeaderText("Test record details");

            Field(x => x.Title);
            Field(x => x.TestDescription);
            Field(x => x.TestNumber);
            Field(x => x.Procedure);

            Button("Cancel").OnClick(x => x.ReturnToPreviousPage());

            Button("Save").IsDefault().Icon(FA.Check)
            .OnClick(x =>
            {
                x.SaveInDatabase();
                x.GentleMessage("Saved successfully.");
                x.ReturnToPreviousPage();
            });
        }
    }
}