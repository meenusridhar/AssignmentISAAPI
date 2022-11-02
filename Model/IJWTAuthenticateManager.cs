using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentISAAPI.Model
{
    public interface IJWTAuthenticateManager
    {
        string Authenticate(string userName, string password);
    }
}
