﻿using amir_apparel_demo_api_dotnet_5.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace amir_apparel_demo_api_dotnet_5.Data.Context
{
    public interface IApplicationContext
    {
        DbSet<T> Products { get; set; }
    }
}
