using System;
using Xunit;
using Exercise004;
using TestMyCode.CSharp.API.Attributes;
using System.Reflection;


namespace ProgramTests
{
  [Points("4-4")]
  public partial class ProgramTest
  {
    [Fact]
    public void TestExerciseRoomCreation()
    {
        Room room = new Room("test", 12);
        // Assert
        Assert.Equal(typeof(Room), room.GetType());
    }

    [Fact]
    public void TestLargerExerciseRoomCreation()
    {
        Room room = new Room("This is a test room", 464);

        // Assert
        Assert.Equal(typeof(Room), room.GetType());
      
    }

    [Fact]
    public void TestRoomAttributes()
    {
      Room room = new Room("This is a smaller test room", 333);

      Type typ = typeof(Room);
      FieldInfo code = typ.GetField("code", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
      FieldInfo seats = typ.GetField("seats", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
      var actualCode = code.GetValue(room);
      var actualSeats = seats.GetValue(room);

      // Assert
      Assert.IsType(typeof(string), actualCode);
      Assert.Equal("This is a smaller test room", actualCode);
      Assert.IsType(typeof(int), actualSeats);
      Assert.Equal(333, actualSeats);
    }
  }


}
