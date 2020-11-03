using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UserAuth.Controllers
{
    public class ForumController : Controller
    {
        public IActionResult ForumPosts()
        {
            return View();
        }
    }
}
