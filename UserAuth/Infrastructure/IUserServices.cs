using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserAuth.Areas.Identity.Data;

namespace UserAuth.Infrastructure

{
    public interface IUserServices
    {
        MinervaUser Save(MinervaUser mUser);

        MinervaUser GetSavedUser();
    }
}
