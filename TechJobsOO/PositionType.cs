using System;
namespace TechJobsOO
{
    public class PositionType : Entity
    {
        public string? Value { get; set; }

        public PositionType(string value) : base()
        {
            Value = value;
        }

        public override bool Equals(object? obj)
        {
            return obj is PositionType type &&
                   Id == type.Id;
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
