using System;
using System.IO;
using Xunit;
using Exercise008;
using TestMyCode.CSharp.API.Attributes;

namespace ProgramTests
{
    public partial class ProgramTest
    {
        [Fact]
        [Points("1-8")]
        public void TestReturnsGreeting()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);
                var input = new StringReader("Ada");
                Console.SetIn(input);
                Program.Main(null);
                Console.SetOut(stdout);

                Assert.Equal("What is your name?\nHello Ada!\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }
    }
}
