using HttpMessenger.Database.Entities;
using RepositoryDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpMessenger.Database.Repositories
{
    public class UserRepository : Repository<User>
    {
        public UserRepository(MainContext mainContext) : base(mainContext)
        {

        }
    }
}
