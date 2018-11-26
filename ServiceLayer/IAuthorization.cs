﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public interface IAuthorization
    {
        string CheckUserRole(User user);
        string HasPermission();
    }
}