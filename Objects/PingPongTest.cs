using Xunit;
using System.Collections.Generic;
using System;
namespace PingPong
{
  public class PingPongTest
  {
    [Fact]
    public void IsPingPong_ForNumbers_true()
    {
    int number = 15000;
    PingPong newPingPong = new PingPong(number);
    List<string> pingList = PingPong.Play();
    List<string> newList = new List<string> { "1", "2", "ping" };

    foreach (var item in pingList)
    {
      Console.WriteLine("Output: " + item);
    }

    Assert.Equal(newList, pingList);
    }
  }
}
