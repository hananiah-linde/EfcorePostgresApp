﻿using EfcoreLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace EfcoreLibrary;
public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<Contact> Contacts { get; set; }
}