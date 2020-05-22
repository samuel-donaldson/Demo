using MSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace UI.Modules.Input
{
    class GenericInputForm : InputBaseForm<Domain.Input>
    {
        protected override bool AddType() => true;
    }
}
