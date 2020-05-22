using MSharp;

namespace Domain
{
    class InputDataType : EntityType
    {
        public InputDataType()
        {
            InstanceAccessors("Generic", "Weight", "Meter", "Millimeter");
            String("Name").Mandatory().Unique();
            String("Input control info");
        }
    }
}