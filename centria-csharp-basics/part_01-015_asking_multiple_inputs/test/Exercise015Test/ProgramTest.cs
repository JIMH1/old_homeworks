using System;
using System.IO;
using Exercise015;
using Xunit;
using TestMyCode.CSharp.API.Attributes;

namespace ProgramTests
{
  [Points("1-15")]
  public partial class ProgramTest
  {
    [Fact]
    public void TestExercise15()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "word",
                "12",
                Convert.ToDouble("3.2", System.Globalization.CultureInfo.InvariantCulture).ToString(),
                "true"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.Contains("Give a string:\nGive an integer:\nGive a double:\nGive a boolean:\nYour string: word\nYour integer: 12\nYour double: "+ (3.2).ToString().Replace(",",".") +"\nYour boolean: True\n", sw.ToString().Replace(",",".").Replace("\r\n", "\n"));
      }
    }
  }
}
