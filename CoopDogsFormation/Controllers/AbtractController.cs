using CoopDogsFormation.Utilities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoopDogsFormation.Controllers
{
    public class AbtractController : Controller
    {
        public virtual void AlertMessage(Tuple<bool, string> res)
        {
            if (res.Item1)
                ViewBag.AlertType = "success";
            else
                ViewBag.AlertType = "danger";
            ViewBag.AlertMsg = res.Item2;
        }

        public virtual int GetUserId()
        {
            List<Claim> claims = User?.Claims.ToList();
            return Convert.ToInt32(claims[ClaimConsts.Id].Value);
        }
    }
}
