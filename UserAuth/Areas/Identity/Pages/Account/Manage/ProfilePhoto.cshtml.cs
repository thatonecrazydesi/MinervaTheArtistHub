using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using UserAuth.Areas.Identity.Data;

namespace UserAuth.Areas.Identity.Pages.Account.Manage
{
    public class ProfilePhotoController : Controller
    {
        [HttpGet]
        public IActionResult ProfilePic()
        {
            return View();
        }

    }
}
