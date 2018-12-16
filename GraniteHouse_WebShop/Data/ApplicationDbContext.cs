﻿using System;
using System.Collections.Generic;
using System.Text;
using GraniteHouse_WebShop.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GraniteHouse_WebShop.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ProductTypes> ProductTypes { get; set; }
        public DbSet<SpecialTags> SpecialTags { get; set; }
    }
}
