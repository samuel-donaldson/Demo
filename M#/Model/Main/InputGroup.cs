using MSharp;

namespace Domain
{
    class InputGroup : EntityType
    {
        public InputGroup()
        {
            SortableByOrder();
            var test = Associate<TestRecord>("Test").Mandatory();
            var name = String("Name").Mandatory();

            UniqueCombination(new Property[] { name, test });
        }
    }
}