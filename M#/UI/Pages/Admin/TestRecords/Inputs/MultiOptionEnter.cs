using MSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace UI.Pages.Admin.TestRecords.Inputs
{
    class MultiOptionEnterPage : SubPage<global::Admin.TestRecords.InputsPage>
    {
        public MultiOptionEnterPage()
        {
            Add<Modules.Input.MultiOptionInputForm>();
        }
    }
}
