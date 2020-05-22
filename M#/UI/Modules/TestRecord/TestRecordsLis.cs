using MSharp;
using System;

namespace Modules
{
    class TestRecordsLis : ListModule<Domain.TestRecord>
    {
        public TestRecordsLis()
        {
            HeaderText("Test records");

            Search(GeneralSearch.AllFields).Label("Find:");

            Column(x => x.Title);
            Column(x => x.TestDescription);
            Column(x => x.TestNumber);

            
            /*M#:w[18]T-Prop:Name-Type:ListButton-Button name should not contain underline.*/LinkColumn(x => x.Inputs).Text("@(await item.Inputs.Count())").OnClick(x => x.Go<Admin.TestRecords.InputsPage>().Send("testrecord", "@item.ID"));

            ButtonColumn("Edit").HeaderText("Actions").GridColumnCssClass("actions").Icon(FA.Edit)
                .OnClick(x => x.Go<Admin.TestRecords.EnterPage>().SendItemId().SendReturnUrl());

            Button("New Test record").Icon(FA.Plus)
                .OnClick(x => x.Go<Admin.TestRecords.EnterPage>().SendReturnUrl());
        }
    }
}
