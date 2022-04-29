﻿using Microsoft.AspNetCore.Identity;

namespace Lea.Data.Configurations;

public class IdentityOptionsProvider
{
    public static void IdentityOptions(IdentityOptions options)
    {
        options.Password.RequireDigit = false;
        options.Password.RequireLowercase = false;
        options.Password.RequireUppercase = false;
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequiredLength = 6;
        options.Lockout.AllowedForNewUsers = true;
        options.Lockout.MaxFailedAccessAttempts = 3;
    }
}
