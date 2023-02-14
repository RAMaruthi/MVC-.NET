using longIn.DataCompoent;
using longIn.DataRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace longIn.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            if (Session["CustomerUser"] != null)
            {
                var cstDetails = Session["CustomerUser"] as CustomerTbl ;
                return $"<h1>HomePage</h1></hr><p>Welcome come to  User {cstDetails.cstName}";
            }
            else
            {
                return $"<h1>HomePage</h1></hr><p>Welcome";
            }
        }


    }
}