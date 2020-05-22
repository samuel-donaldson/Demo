using MSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace UI.Pages.Admin.TestRecords.Inputs
{
    class GenericEnterPage : SubPage<global::Admin.TestRecords.InputsPage>
    {
        public GenericEnterPage()
        {
            Add<Modules.Input.GenericInputForm>();
        }
    }
}
