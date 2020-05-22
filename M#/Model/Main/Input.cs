using MSharp;

namespace Domain
{
    class Input : EntityType
    {
        public Input()
        {
            SortableByOrder();

            Associate<TestRecord>("Test").Mandatory();
            /*M#:w[11]T-Prop:DatabaseIndex-Type:Association-This association is referenced in its inverse association. So it's likely to get frequent queries on this column. Consider putting an index on it.*//*M#:w[11]T-Prop:DatabaseIndex-Type:Association-This association is referenced in its inverse association. So it's likely to get frequent queries on this column. Consider putting an index on it.*/Associate<InputGroup>("Group");
            String("Title").Mandatory();
            String("Description");
            Bool("Mandatory").Mandatory();
            Associate<InputDataType>("Type").Default("Generic").Mandatory();
        }
    }
}
