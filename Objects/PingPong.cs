using System;
using System.Collections.Generic;

namespace PingPong
{
  public class PingPong
  {
    public static List<int> newList = new List<int> {};
    public static List<string> pingList = new List<string> {};

    public PingPong(int inputnumber)
    {

      for(int i=1; i<=inputnumber; i++)
      {
        newList.Add(i);
      }
    foreach (int listItem in newList)
      {
        if (listItem % 15 == 0) {
          pingList.Add("ping-pong");
        }else if (listItem % 3 == 0) {
          pingList.Add("ping");
        }else if (listItem % 5 == 0) {
          pingList.Add("pong");
        }else {
          pingList.Add(listItem.ToString());
        }
      }
    }
    public static List<string> Play()
    {
      return pingList;
    }
    public static void DeleteAll()
    {
      newList.Clear();
      pingList.Clear();
    }
  }
}
