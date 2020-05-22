using MSharp;

namespace Domain
{
    class TestRecord : EntityType
    {
        public TestRecord()
        {
            String("Title").Mandatory();
            BigString("Test description");
            String("Test number").Mandatory();
            String("Procedure");
            InverseAssociate<Input>("Inputs", "Test");

        }
    }
}