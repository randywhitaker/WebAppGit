using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAppGit.Controllers
{
  public class NamesController : ApiController
  {
    public string[] get()
    {
      return new string[] { "Tim", "Bob", "Sam", "All", "Dan", "Car", "Cat" };
    }
  }
}
