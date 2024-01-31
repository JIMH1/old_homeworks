using System;
using System.IO;
using Xunit;
using Exercise010;
using TestMyCode.CSharp.API.Attributes;


namespace ProgramTests
{
  [Points("1-10")]
  public partial class ProgramTest
  {
    [Fact]
    public void TestReturnsTrue()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;
        Console.SetOut(sw);
        
        var data = String.Join(Environment.NewLine, new[]
                {
                "Ada",
                "Data Scientist"
                });
        Console.SetIn(new System.IO.StringReader(data));
        Program.Main(null);
        Console.SetOut(stdout);

         Assert.Contains("I will tell a story, but I need some information.\nGive a name for main character:\n" +
                "Give the character a profession:\nHere is the story:\n" +
                "Once upon a time there was a Data Scientist called Ada\n" +
                "On her way to work, Ada often pondered what being Data Scientist meant to them.\n" +
                "When you work as a Data Scientist you meet interesting people.\n" +
                "Ada enjoys their work as Data Scientist, The end.\n", sw.ToString().Replace("\r\n", "\n"));      
                }
    }
  }
}

  
  
