using BlogLab.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogLab.Services
{
    public interface ITokenServices
    {
        public string CreateToken(ApplicationUserIdentity user);
    }
}
