using IdentityServer4.Stores;
using IdentityServer4.Validation;
using Ling.Identity.Interfaces.Repositories;
using Ling.Identity.Interfaces.Services;
using Ling.Identity.Repositories.ClientAggregate.InMemory;
using Ling.Identity.Repositories.PersistedGrantAggregate;
using Ling.Identity.Repositories.ResourceAggregate.InMemory;
using Ling.Identity.Repositories.UserAggregate.InMemory;
using Ling.Identity.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ling.Identity
{
    public static class IdentityServerExtensions
    {
        public static IIdentityServerBuilder AddLingIdentitySServer(this IIdentityServerBuilder builder, IConfigurationRoot config)
        {
            builder.Services.ConfigurePOCO(config.GetSection("IdentityOptions"), () => new IdentityOptions());
            builder.Services.AddTransient<IUserRepository, UserInMemoryRepository>();
            builder.Services.AddTransient<IResourceRepository, ResourceInMemoryRepository>();
            builder.Services.AddTransient<IClientRepository, ClientInMemoryRepository>();
            builder.Services.AddTransient<IClientStore, ClientInMemoryRepository>();
            builder.Services.AddTransient<IResourceStore, ResourceInMemoryRepository>();
            builder.Services.AddTransient<IPersistedGrantStore, PersistedGrantStore>();
            //services
            builder.Services.AddTransient<IUserService, UserService>();
            builder.Services.AddTransient<IPasswordService, PasswordService>();
            //validators
            builder.Services.AddTransient<IResourceOwnerPasswordValidator, ResourceOwnerPasswordValidator>();

            builder.AddProfileService<ProfileService>();

            return builder;
        }
    }
}