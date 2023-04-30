﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemberApi.Models
{
    public interface IMenuMasterService
    {
        IEnumerable<MenuMaster> GetMenuMaster();
        IEnumerable<MenuMaster> GetMenuMaster(String UserRole);
    }
}
