using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UserAuth.Areas.Identity.Data;
using UserAuth.Data;
using UserAuth.IServices;
using UserAuth.Models;

namespace UserAuth.Controllers
{
    public class ProfilePicController : Controller
    {

        public readonly UserAuthDBContext _context;
        public readonly UserManager<MinervaUser> _userManager;
        IUserServices _userService = null;
        public class InputModel
        {
            
            [Display(Name = "Profile Photo")]
            public byte[] ProfileImage { get; set; }

            
        }

        [HttpGet]
        public IActionResult Index
        [HttpPost]
        public string SaveFile(FileUpload fileObj)
        {

            MinervaUser mUser = JsonConvert.DeserializeObject<MinervaUser>(fileObj.FileName);
            if (fileObj.file.Length > 0)
            {
                using (var ms = new MemoryStream())
                {
                    fileObj.file.CopyTo(ms);
                    var fileBytes = ms.ToArray();
                    mUser.ProfileImage = fileBytes;
                    mUser = _userService.Save(mUser);
                    if (mUser.Id != null)
                    {
                        return "Saved";// An image can be uploaded after the user account is made
                    }
                }
            }
            return "Failed";
        }

        [HttpGet]
        public JsonResult GetSavedUser()
        {
            var user = _userService.GetSavedUser();
            user.ProfileImage = this.GetImage(Convert.ToBase64String(user.ProfileImage));
            return Json(user);
        }

        public byte[] GetImage(string sBase64String)
        {
            byte[] bytes = null;
            if (!string.IsNullOrEmpty(sBase64String))
            {
                bytes = Convert.FromBase64String(sBase64String);
            }
            return bytes;
        }

    }
}
