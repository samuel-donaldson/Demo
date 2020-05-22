using MSharp;

namespace Domain
{
    class InputOption : EntityType
    {
        public InputOption()
        {            
            Associate<MultipleOptionInput>("Input").Mandatory().DatabaseIndex();
            String("Value");
        }
    }
}
