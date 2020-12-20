using Hff.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hff.Core.Entities.Concrete
{
    public class User:IEntity
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public bool Status { get; set; }
    }
}
