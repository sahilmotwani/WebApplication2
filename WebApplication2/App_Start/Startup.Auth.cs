using Owin;
using Microsoft.Owin.Security;
using System.IdentityModel.Tokens;
using System.Configuration;
using Microsoft.Owin.Security.ActiveDirectory;
using Microsoft.IdentityModel.Tokens;

namespace WebApplication2
{
    public partial class Startup
    {
        public void ConfigureAuth(IAppBuilder app)
        {
            app.UseWindowsAzureActiveDirectoryBearerAuthentication(
                new WindowsAzureActiveDirectoryBearerAuthenticationOptions
                {
                    Tenant = ConfigurationManager.AppSettings["Tenant"],
                    TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidAudience = ConfigurationManager.AppSettings["Audience"]
                    }
                });
        }
    }
}