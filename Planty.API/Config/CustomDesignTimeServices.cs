namespace Planty.API.Config
{
    using Microsoft.EntityFrameworkCore.Design;
    using Microsoft.EntityFrameworkCore.Migrations.Design;
    using Microsoft.Extensions.DependencyInjection;

    public class CustomDesignTimeServices : IDesignTimeServices
    {
        public void ConfigureDesignTimeServices(IServiceCollection serviceCollection)
            => serviceCollection.AddSingleton<IMigrationsCodeGenerator, CustomCSharpMigrationsGenerator>();
    }
}
