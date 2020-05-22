using MSharp;

namespace Domain
{
    class DynamicInputField : EntityType
    {
        public DynamicInputField()
        {
            SortableByOrder();
            var name = String("Name").Mandatory();
            
            /*M#:w[11]T-Prop:DatabaseIndex-Type:Association-This association is referenced in its inverse association. So it's likely to get frequent queries on this column. Consider putting an index on it.*//*M#:w[11]T-Prop:DatabaseIndex-Type:Association-This association is referenced in its inverse association. So it's likely to get frequent queries on this column. Consider putting an index on it.*//*M#:w[11]T-Prop:DatabaseIndex-Type:Association-This association is referenced in its inverse association. So it's likely to get frequent queries on this column. Consider putting an index on it.*//*M#:w[11]T-Prop:DatabaseIndex-Type:Association-This association is referenced in its inverse association. So it's likely to get frequent queries on this column. Consider putting an index on it.*//*M#:w[11]T-Prop:DatabaseIndex-Type:Association-This association is referenced in its inverse association. So it's likely to get frequent queries on this column. Consider putting an index on it.*//*M#:w[11]T-Prop:DatabaseIndex-Type:Association-This association is referenced in its inverse association. So it's likely to get frequent queries on this column. Consider putting an index on it.*//*M#:w[11]T-Prop:DatabaseIndex-Type:Association-This association is referenced in its inverse association. So it's likely to get frequent queries on this column. Consider putting an index on it.*//*M#:w[11]T-Prop:DatabaseIndex-Type:Association-This association is referenced in its inverse association. So it's likely to get frequent queries on this column. Consider putting an index on it.*//*M#:w[11]T-Prop:DatabaseIndex-Type:Association-This association is referenced in its inverse association. So it's likely to get frequent queries on this column. Consider putting an index on it.*/var input = Associate<DynamicInput>("Input");
            String("Group");

            UniqueCombination(new Property[] { name, input });
        }
    }
}
