using System;
namespace TechJobsOO
{
    public class Location : Entity
    {
        public string? Value { get; set; }

        public Location(string value) : base()
        {
            Value = value;
        }

        public override bool Equals(object? obj)
        {
            return obj is Location location &&
                   Id == location.Id;
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
