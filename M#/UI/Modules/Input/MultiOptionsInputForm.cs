using MSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace UI.Modules.Input
{
    class MultiOptionsInputForm : InputBaseForm<Domain.MultipleOptionsInput>
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
