using MSharp;

namespace Domain
{
    class MultipleOptionsInput : SubType<Input>
    {
        public MultipleOptionsInput()
        {
            InverseAssociate<InputOption>("Options", "Input");
        }
    }
}