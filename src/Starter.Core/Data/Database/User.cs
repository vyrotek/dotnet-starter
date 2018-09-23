using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Starter.Core.Data.Database
{
    [Table(Name = "User")]
    public class User
    {
        [PrimaryKey, Identity]
        public int Id { get; set; }

        [Column, NotNull]
        public string Email { get; set; }

        [Column, NotNull]
        public string Name { get; set; }

        [Column, NotNull]
        public DateTime CreatedAt { get; set; }
    }
}
