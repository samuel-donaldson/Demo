using MSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace UI.Modules.Input
{
    class MultiOptionInputForm : InputBaseForm<Domain.MultipleOptionInput>
    {
        protected override void AddFields()
        {
            base.AddFields();

            MasterDetail(x => x.Options, f =>
            {
                f.Field(d => d.Value);

                f.Button("Add a new option").OnClick(x => x.AddMasterDetailRow());
            });
        }
    }
}
