using MSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace UI.Pages.Admin.TestRecords.Inputs
{
    class DynamicEnterPage : SubPage<global::Admin.TestRecords.InputsPage>
    {
        public DynamicEnterPage()
        {
            Add<Modules.Input.DynamicInputEnter>();
        }
    }
}
