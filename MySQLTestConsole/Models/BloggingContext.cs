using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using MySQLTestConsole.Models;

namespace MySQLTestConsole.Models
{
    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //配置mariadb连接字符串
            optionsBuilder.UseMySql("Server=localhost;Port=3306;Database=coremysqltestdb; User=sharkyzh;Password=163.com;");
        }
    }
}
