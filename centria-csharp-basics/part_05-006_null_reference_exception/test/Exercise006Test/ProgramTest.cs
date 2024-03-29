using System;
using System.IO;
using Xunit;
using Exercise006;
using TestMyCode.CSharp.API.Attributes;

namespace ProgramTests
{
    public partial class ProgramTest
    {
        [Fact]
        [Points("5-6")]
        public void TestExerciseException()
        {
            Assert.Throws<NullReferenceException>(() => Program.Main(null));
        }
    }
}
