using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MyLibrary;

namespace WebAppGit.Controllers
{
  public class NamesController : ApiController
  {
    public string[] get()
    {
      var team = new Team();
      return team.Names();
    }
  }
}
