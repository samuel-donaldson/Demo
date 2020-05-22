using MSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace UI.Modules.Input
{
    class DynamicInputEnter : InputBaseForm<Domain.DynamicInput>
    {
        protected override void AddFields()
        {
            base.AddFields();

            MasterDetail(x => x.Fields, f =>
            {
                f.Field(x => x.Group);
                f.Field(x => x.Name);

                f.Button("Add a new field").OnClick(x => x.AddMasterDetailRow());
            });
        }
    }
}
