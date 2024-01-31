using System;
using System.IO;
using Xunit;
using Exercise017;
using TestMyCode.CSharp.API.Attributes;

namespace ProgramTests
{
    [Points("2-17")]
  public partial class ProgramTest
  {
    [Fact]  
    public void TestSumOfNumbersMain()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;
        Console.SetOut(sw);
        Program.Main(null);
        Console.SetOut(stdout);
        string comparison = "Sum: 14";
        
        Assert.Contains(comparison, sw.ToString().Replace("\r\n", "\n"));
      }
    }

    public void TestSumOfNumbersMethod()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;
        Console.SetOut(sw);
        var data = String.Join(Environment.NewLine, new[]
        {
          "3", "5", "7", "2"
        });
        Console.SetIn(new System.IO.StringReader(data));

        Program.Sum(
          Convert.ToInt32(data[0]),
          Convert.ToInt32(data[1]),
          Convert.ToInt32(data[2]),
          Convert.ToInt32(data[3]));
        Console.SetOut(stdout);
        string comparison = "Sum: 17";
        
        Assert.Contains(comparison, sw.ToString().Replace("\r\n", "\n"));
      }
    }
  }
}

