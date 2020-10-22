using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserAuth.Areas.Identity.Data;
using UserAuth.Data;
using UserAuth.IServices;

namespace UserAuth.Services
{
    public class UserServices : IUserServices
    {
        private readonly UserAuthDBContext _context;
        public UserServices(UserAuthDBContext context)
        {
            _context = context;
        }
        public MinervaUser GetSavedUser()// Testing to see if using IdentityUser will populate all the Properties
        {
            return _context.Users.SingleOrDefault();
        }

        public MinervaUser Save(MinervaUser mUser)// Can this work?
        {
            _context.Users.Add(mUser);
            _context.SaveChanges();
            return mUser;
        }
    }
}
