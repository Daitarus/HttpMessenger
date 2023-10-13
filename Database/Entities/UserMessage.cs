using RepositoryDB;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpMessenger.Database.Entities
{
    [Table("Users")]
    public class UserMessage : Entity
    {

        public int SenderId { get; set; }

        public int RecipientId { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [MaxLength(256)]
        [Required]
        public string Message { get; set; }
    }
}
