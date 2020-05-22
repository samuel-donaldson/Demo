using MSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace UI.Modules.Input
{
    abstract class InputBaseForm<TInput> : FormModule<TInput> where TInput : Domain.Input
    {
        public InputBaseForm()
        {
            HeaderText("Input details");
            AutoSet(x => x.Test).FromRequestParam("testrecord");

            AddFields();

            Button("Cancel").OnClick(x =>
            {
                x.ReturnToPreviousPage();
            });

            Button("Save").OnClick(x =>
            {
                x.SaveInDatabase();
                x.ReturnToPreviousPage();
            });

        }

        protected virtual bool AddType() => false;
        protected virtual void AddFields()
        {
            Field(c => c.Title);
            Field(c => c.Description);
            
            if (AddType())
                /*M#:w[36]T-Prop:SetInPostback-Type:AutomaticPropertySetter-The value of this property is changeable by the user on the form. It should not set the value in post-back.*/Field(c => c.Type).Control(ControlType.HorizontalRadioButtons).AutoSet(c => c.Value("InputDataType.Generic"));
            Field(c => c.Mandatory);
        }
    }
}
