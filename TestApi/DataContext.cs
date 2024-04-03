using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TestApi;
using TestApi.Model;

namespace TestApi
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Employee> Todo => Set<Employee>();
    }
}

