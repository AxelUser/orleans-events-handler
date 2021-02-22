namespace OrleansEventsHandler.Domain.Models.Segments
{
    public class PayloadCondition
    {
        public string FieldName { get; set; }

        public string Value { get; set; }

        public ConditionType ConditionType { get; set; }
    }

    public enum ConditionType
    {
        NotEquals,
        Equals,
        GreaterThan,
        GreaterThanOrEquals,
        LessThan,
        LessThanOrEquals,
        
        Contains,
        StartsWith,
        EndsWith
    }
}