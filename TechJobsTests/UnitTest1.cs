using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class UnitTest1
    {
        public const string PRODUCT_TEST = "Product test";
        public const string EMPLOYER = "ACME";
        public const string LOCATION = "Desert";
        public const string POSITION = "Quality control";
        public const string CORE = "Persistence";

        public Job GetJob()
        {
            return new Job(PRODUCT_TEST,
                            new Employer(EMPLOYER),
                            new Location(LOCATION),
                            new PositionType(POSITION),
                            new CoreCompetency(CORE));
        }

        [TestMethod]
        public void TestSettingJobId()
        {
            Job job = GetJob();

            Job job2 = GetJob();

            Assert.IsTrue(job2.Id != job.Id);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job job = GetJob();

            Assert.IsTrue(job.Name == PRODUCT_TEST &&
                          job.Employer?.Value == EMPLOYER &&
                          job.Location?.Value == LOCATION &&
                          job.PositionType?.Value == POSITION &&
                          job.CoreCompetency?.Value == CORE);
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job job = GetJob();

            Job job2 = GetJob();

            Assert.IsFalse(job.Equals(job2));
        }

        [TestMethod]
        public void JobToStringHasDelimiters()
        {
            Job job = GetJob();

            string s = job.ToString();

            string[] arr = s.Split("\n");

            Assert.IsTrue(arr.Count() >= 2 && arr.First() == string.Empty && arr.Last() == string.Empty);
        }

        [TestMethod]
        public void JobToStringPrintsArgsOnNewLines()
        {
            Job job = GetJob();

            string s = job.ToString();

            string[] arr = s.Split("\n");

            Assert.IsTrue(arr.Any(s => s == $"ID: {job.Id}"));
            Assert.IsTrue(arr.Any(s => s == $"Name: {job.Name}"));
            Assert.IsTrue(arr.Any(s => s == $"Employer: {job.Employer}"));
            Assert.IsTrue(arr.Any(s => s == $"Location: {job.Location}"));
            Assert.IsTrue(arr.Any(s => s == $"Position Type: {job.PositionType}"));
            Assert.IsTrue(arr.Any(s => s == $"Core Competency: {job.CoreCompetency}"));
        }

        [TestMethod]
        public void JobToStringPrintsNullArgsCoallesceOnPrint()
        {
            Job job = new Job();

            string s = job.ToString();

            string[] arr = s.Split("\n");

            Assert.IsTrue(arr.Any(s => s == $"ID: {job.Id}"));
            Assert.IsTrue(arr.Any(s => s == $"Name: {job.Name ?? "Data not available"}"));
            Assert.IsTrue(arr.Any(s => s == $"Employer: {job.Employer?.ToString() ?? "Data not available"}"));
            Assert.IsTrue(arr.Any(s => s == $"Location: {job.Location?.ToString() ?? "Data not available"}"));
            Assert.IsTrue(arr.Any(s => s == $"Position Type: {job.PositionType?.ToString() ?? "Data not available"}"));
            Assert.IsTrue(arr.Any(s => s == $"Core Competency: {job.CoreCompetency?.ToString() ?? "Data not available"}"));
        }
    }
}
