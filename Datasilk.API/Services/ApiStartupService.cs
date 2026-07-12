using Datasilk.Data.Services;
using Microsoft.AspNetCore.Builder;

namespace Datasilk.API.Services
{
    public static class ApiStartupService
    {
        public static void AddApiStartupService(this WebApplicationBuilder builder)
        {
            builder.AddDapperStartupService();
        }
    }
}
