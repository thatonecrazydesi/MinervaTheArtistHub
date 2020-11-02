using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using UserAuth.Areas.Identity.Data;
using UserAuth.Data;
using UserAuth.IServices;
using UserAuth.Models;

namespace UserAuth.Controllers
{
    [Authorize]// This controller is only accessible when the user is authenicated.
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        public readonly UserAuthDBContext _context;
        public readonly UserManager<MinervaUser> _userManager;
        IUserServices _userService = null;



        public HomeController(UserAuthDBContext context, UserManager<MinervaUser> userManager, IUserServices userServices)
        {
            _context = context;
            //_logger = logger;
            _userManager = userManager;
            _userService = userServices;
        }

        //Add Action for INDEX Page
        //Add Action for FORUM Page

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MarketPlace()// Filter information to view events, and pictures
        {
            return View();
        }
        public IActionResult Forum()// public forums
        {
            return View();
        }
        public IActionResult Events()
        {
            return View();
        }
        public async Task<IActionResult> Chatroom()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            if (User.Identity.IsAuthenticated)
            {
                ViewBag.CurrentUserName = currentUser.UserName;
            }

            var messages = await _context.Messages.ToListAsync();
            return View(messages);
        }

        public async Task<IActionResult> Create(ChatRoom message)
        {
            if (ModelState.IsValid)
            {
                message.UserName = User.Identity.Name;
                var sender = await _userManager.GetUserAsync(User);
                message.UserId = sender.Id;
                await _context.Messages.AddAsync(message);
                await _context.SaveChangesAsync();
                return Ok();
            }
            return Error();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
