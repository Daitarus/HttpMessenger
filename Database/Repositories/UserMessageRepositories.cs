using HttpMessenger.Database.Entities;
using RepositoryDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpMessenger.Database.Repositories
{
    public class UserMessageRepositories : Repository<UserMessage>
    {
        public UserMessageRepositories(MainContext mainContex) : base (mainContex) 
        { 

        }
    }
}
