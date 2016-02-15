using System;
using System.Collections.Generic;
//
// class PingPong
// {
//   static void Main()
//   {
//     Console.WriteLine("Enter a number");
//     string stringNumber = Console.ReadLine();
//     int inputNumber = int.Parse(stringNumber);
//
//     List<int> newList = new List<int> {};
//
//     for (int i = 1; i <= inputNumber; i++)
//     {
//       newList.Add(i);
//     }
//
//
//     Console.WriteLine("Output");
//     foreach (int listItem in newList)
//     {
//       if (listItem % 15 == 0) {
//         Console.WriteLine("ping-pong");
//       }
//       else if (listItem % 3 == 0) {
//       Console.WriteLine("ping");
//     } else if (listItem % 5 == 0) {
//       Console.WriteLine("pong");
//     } else {
//       Console.WriteLine(listItem);
//       }
//     }
//   }
// }

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
