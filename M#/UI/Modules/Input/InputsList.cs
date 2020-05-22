using Domain;
using MSharp;
using UI.Pages.Admin.TestRecords.Inputs;

namespace Modules
{
    class InputsList : ListModule<Domain.Input>
    {
        public InputsList()
        {
            HeaderText("Inputs");
            ViewModelProperty<TestRecord>("TestRecord").FromRequestParam("testrecord");
            DataSource("await info.TestRecord.Inputs.GetList()");
            Search(GeneralSearch.AllFields).Label("Find:");


            LinkColumn("Sort").NoText().Icon(FA.Sort).OnClick(x => x.DragSort());
            CustomColumn("Type").DisplayExpression("@item.GetTypeName()");
            Column(x => x.Title);
            CustomColumn("Options").HeaderTemplate("Options").CellVisibleIf("item is MultipleOptionsInput").DisplayExpression("@(await (item as MultipleOptionsInput).Options.Count())");
            CustomColumn("Fields").LabelText("Fields").CellVisibleIf("item is DynamicInput").DisplayExpression("@(await (item as DynamicInput).Fields.Count())");
            Column(x => x.Description);
            Column(x => x.Mandatory);

            ButtonColumn("Edit").HeaderText("Actions").GridColumnCssClass("actions").Icon(FA.Edit)
                /*M#:w[25]T-Prop:Key-Type:QueryStringParameter-The destination page doesn't seem to utilise Query String 'testrecord' anywhere.*//*M#:w[25]T-Prop:SendReturnUrl-Type:NavigateActivity-The destination page is not using ReturnUrl in any way.*/.OnClick(x => x.Go<UI.Pages.Admin.TestRecords.Inputs.DispatchPage>().SendItemId().Pass("testrecord").SendReturnUrl());

            Button("Add a new Generic input").OnClick(x => x.Go<GenericEnterPage>().Pass("testrecord").SendReturnUrl());
            Button("Add a new Multi Option input").OnClick(x => x.Go<MultiOptionEnterPage>().Pass("testrecord").SendReturnUrl());
            Button("Add a new Dynamic input").OnClick(x => x.Go<DynamicEnterPage>().Pass("testrecord").SendReturnUrl());
        }
    }
}
