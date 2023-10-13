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
    public class User : Entity
    {
        [MaxLength(20)]
        [Required]
        public string Name { get; set; }

        [Required]
        public Guid Token { get; set; }
    }
}
