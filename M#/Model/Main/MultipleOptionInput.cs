using MSharp;

namespace Domain
{
    class MultipleOptionInput : SubType<Input>
    {
        public MultipleOptionInput()
        {
            InverseAssociate<InputOption>("Options", "Input");
        }
    }
}