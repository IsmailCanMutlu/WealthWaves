using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WealthWaves.Api.Models;

namespace WealthWaves.Api.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}