﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace FilmPuanlamaSitesi.Models.Siniflar
{
    public class Context : DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactUs> ContactUses { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Kullanici> Kullanicis { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-89DCQGD\\SQLEXPRESS;Initial Catalog=FilmDb;Integrated Security=True");
        }
    }
}
