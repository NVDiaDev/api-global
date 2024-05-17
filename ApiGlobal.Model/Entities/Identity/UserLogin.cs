﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiGlobal.Model.Entities.Identity
{
    [Table("UserLogins")]
    public class UserLogin : IdentityUserLogin<Guid>
    {

    }
}
