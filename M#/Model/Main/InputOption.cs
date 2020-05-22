using MSharp;

namespace Domain
{
    class InputOption : EntityType
    {
        public InputOption()
        {            
            Associate<MultipleOptionsInput>("Input").Mandatory().DatabaseIndex();
            String("Value");
        }
    }
}
