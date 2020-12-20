using Hff.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hff.Entities.Dtos
{
    public class UserForRegisterDto:IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Firstname  { get; set; }
        public string Lastname { get; set; }
    }
}
