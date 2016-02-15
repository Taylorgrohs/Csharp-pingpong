using Xunit;
using System.Collections.Generic;
using System;
namespace PingPong
{
  public class PingPongTest : IDisposable
  {
    [Fact]
    public void IsPingPong_For3_true()
    {
    int number = 3;
    PingPong newPingPong = new PingPong(number);
    List<string> pingList = PingPong.Play();
    List<string> newList = new List<string> { "1", "2", "ping" };

    foreach (var item in pingList)
    {
      Console.WriteLine("Output: " + item);
    }

    Assert.Equal(newList, pingList);
    }

    [Fact]
    public void IsPingPong_Forfive_true()
    {
    int number = 5;
    PingPong newPingPong = new PingPong(number);
    List<string> pingList = PingPong.Play();
    List<string> newList = new List<string> { "1", "2", "ping", "4", "pong" };

    foreach (var item in pingList)
    {
      Console.WriteLine("Output: " + item);
    }

    Assert.Equal(newList, pingList);
    }

    [Fact]
    public void IsPingPong_Forfifteen_true()
    {
    int number = 15;
    PingPong newPingPong = new PingPong(number);
    List<string> pingList = PingPong.Play();
    List<string> newList = new List<string> { "1", "2", "ping", "4", "pong", "ping", "7", "8", "ping", "pong", "11", "ping", "13", "14", "ping-pong" };

    foreach (var item in pingList)
    {
      Console.WriteLine("Output: " + item);
    }

    Assert.Equal(newList, pingList);
    }
    public void Dispose()
    {
      PingPong.DeleteAll();
    }
  }
}
