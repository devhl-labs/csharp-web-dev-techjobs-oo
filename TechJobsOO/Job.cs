using System;
using System.Collections.Generic;

namespace TechJobsOO
{
    public class Job : Entity
    {
        public string? Name { get; set; }

        public Employer? Employer { get; set; }

        public Location? Location { get; set; }

        public PositionType? PositionType { get; set; }

        public CoreCompetency? CoreCompetency { get; set; }

        public Job() : base()
        {

        }

        public Job(string name, Employer? employer, Location? location, PositionType? positionType, CoreCompetency? coreCompetency) : base()
        {
            Name = name;

            Employer = employer;

            Location = location;

            PositionType = positionType;

            CoreCompetency = coreCompetency;
        }

        public override bool Equals(object? obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            string result = "\n";

            result += $"ID: {Id}\n";
            if (string.IsNullOrEmpty(Name))            
                result += $"Name: Data not available\n";            
            else            
                result += $"Name: {Name}\n";            
            
            result += $"Employer: {Employer?.ToString() ?? "Data not available"}\n";
            result += $"Location: {Location?.ToString() ?? "Data not available"}\n";
            result += $"Position Type: {PositionType?.ToString() ?? "Data not available"}\n";
            result += $"Core Competency: {CoreCompetency?.ToString() ?? "Data not available"}\n";

            result += "\n";

            return result;
        }
    }
}
