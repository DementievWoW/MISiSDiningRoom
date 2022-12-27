using IdentityModel.OidcClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MISiSDiningRoom.Interfacese
{
    public interface IOAuthService
    {
        Task<LoginResult> Login();
        void Logout();
    }
}
