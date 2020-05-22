using MSharp;

namespace Domain
{
    class DynamicInput : SubType<Input>
    {
        public DynamicInput()
        {
            InverseAssociate<DynamicInputField>("Fields", "Input");
        }
    }
}