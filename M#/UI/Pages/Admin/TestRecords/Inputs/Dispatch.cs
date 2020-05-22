using MSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace UI.Pages.Admin.TestRecords.Inputs
{
    class DispatchPage : SubPage<global::Admin.TestRecords.InputsPage>
    {
        public DispatchPage()
        {
            OnStart(x =>
            {
                x.CSharp("var item = await Request.Get<Input>(\"item\");");

                
                /*M#:w[16]T-Prop:SendReturnUrl-Type:NavigateActivity-The destination page uses ReturnUrl which is not provided.*/x.Go<DynamicEnterPage>().Pass("item").If($"item is {nameof(Domain.DynamicInput)}");

                
                /*M#:w[19]T-Prop:SendReturnUrl-Type:NavigateActivity-The destination page uses ReturnUrl which is not provided.*/x.Go<MultiOptionEnterPage>().Pass("item").If(CommonCriterion.ElseIf, $"item is {nameof(Domain.MultipleOptionsInput)}");

                
                /*M#:w[22]T-Prop:SendReturnUrl-Type:NavigateActivity-The destination page uses ReturnUrl which is not provided.*/x.Go<GenericEnterPage>().Pass("item").If(CommonCriterion.Else);
            });
        }
    }
}
