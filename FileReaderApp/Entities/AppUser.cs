using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReaderApp.Entities
{
    public class AppUser
    {
        public string UserId { get; set; }

        public string UserName { get; set; }

        public byte PasswordHash { get; set; }

        public byte PasswordSaltHash { get; set; }
    }
}
