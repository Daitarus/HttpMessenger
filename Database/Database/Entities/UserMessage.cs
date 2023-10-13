using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpMessenger.Repository.Database.Entities
{
    public class UserMessage : Entity
    {
        public int SenderId { get; set; }
        public int RecipientId { get; set; }
        public DateTime Date { get; set; }
        public string Message { get; set; } = string.Empty;
    }
}
