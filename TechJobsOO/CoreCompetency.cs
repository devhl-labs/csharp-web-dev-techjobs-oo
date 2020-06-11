using System;
namespace TechJobsOO
{
    public class CoreCompetency : Entity
    {
        public string? Value { get; }

        public CoreCompetency(string v) : base()
        {
            Value = v;
        }

        public override bool Equals(object? obj)
        {
            return obj is CoreCompetency competency &&
                   Id == competency.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            if (string.IsNullOrEmpty(Value))
                return "Data not available";

            return Value;
        }
    }
}
