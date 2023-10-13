using HttpMessenger.Database.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RepositoryDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpMessenger.Database.Database
{
    public class ApplicationContext : MainContext
    {
        public ApplicationContext(string connectionString) : base(connectionString) { }
        DbSet<User> Users { get; set; }
        DbSet<UserMessage> UserMessages { get; set; }
    }
}
