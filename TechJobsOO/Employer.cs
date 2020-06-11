using System;
namespace TechJobsOO
{
    public class Employer : Entity
    {
        public string? Value { get; set; }

        public Employer(string value) : base()
        {
            Value = value;
        }

        public override bool Equals(object? obj)
        {
            return obj is Employer employer &&
                   Id == employer.Id;
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
