using Nancy;
using System.Collections.Generic;
using PingPong;

namespace PingPong
{
  public class HomeModule: NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/pingpong"] = _ => {
        int pong;
          int.TryParse(Request.Form["new-number"], out pong);
        PingPong newPingPong = new PingPong(pong);
        List<string> pingList = PingPong.Play();
        return View["pingpong.cshtml", pingList];
      };
    }
  }
}
