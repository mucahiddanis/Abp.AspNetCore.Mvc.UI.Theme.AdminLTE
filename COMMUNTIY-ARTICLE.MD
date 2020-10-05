
# Using the AdminLTE Theme with the ABP Framework MVC / Razor Pages UI

This article shows step by step how to use the AdminLTE Theme for ABP Framework MVC / Razor Page UI applications.

First, let's install the ABP CLI tool using the command below.

````shell
dotnet tool install -g Volo.Abp.Cli
````

If it's already installed, you can update it with the following command:

````shell
dotnet tool update -g Volo.Abp.Cli
````

Let's create a sample new project to apply the theme:

````shell
abp new AbpThemeAdminLte
````

Let's create a **theme** folder for the theme project in the project main directory and go to the **theme** directory on the command line:

````shell
mkdir theme
cd theme
````

Let's get the **AdminLTE** theme module project for ABP via git:

````shell
git clone https://github.com/mucahiddanis/Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.git
````

Go back to the project main directory:

````shell
cd ..
cd ..
````

Let's add the AdminLTE theme project to the **sln** file:

````shell
dotnet sln add theme/Abp.AspNetCore.Mvc.UI.Theme.AdminLTE/Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.csproj
````

Let's reference the AdminLTE theme project in our `AbpThemeAdminLte.Web` project:

````shell
<ProjectReference Include="..\..\theme\Abp.AspNetCore.Mvc.UI.Theme.AdminLTE\Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.csproj" />
````

Configure our theme in the `AbpThemeAdminLte.Web.AbpThemeAdminLteWebModule.cs` web module:

````csharp
[DependsOn(
        typeof(AbpThemeAdminLteHttpApiModule),
        typeof(AbpThemeAdminLteApplicationModule),
        typeof(AbpThemeAdminLteEntityFrameworkCoreDbMigrationsModule),
        typeof(AbpAutofacModule),
        typeof(AbpIdentityWebModule),
        typeof(AbpAccountWebIdentityServerModule),
        typeof(AbpAspNetCoreMvcUiBasicThemeModule),
        typeof(AbpAspNetCoreAuthenticationJwtBearerModule),
        typeof(AbpTenantManagementWebModule),
        typeof(AbpAspNetCoreSerilogModule)
        )]
    public class AbpThemeAdminLteWebModule : AbpModule
````


````csharp
typeof(AbpAspNetCoreMvcUiBasicThemeModule),
````

Let's add the following code below the code above:

````csharp
typeof(AbpAspNetCoreMvcUiAdminLTEThemeModule),
````

Add **using** to reference theme project

````csharp
using Abp.AspNetCore.Mvc.UI.Theme.AdminLTE;
````

The **DependsOn** list should finally be:

````csharp
[DependsOn(
        typeof(AbpThemeAdminLteHttpApiModule),
        typeof(AbpThemeAdminLteApplicationModule),
        typeof(AbpThemeAdminLteEntityFrameworkCoreDbMigrationsModule),
        typeof(AbpAutofacModule),
        typeof(AbpIdentityWebModule),
        typeof(AbpAccountWebIdentityServerModule),
        typeof(AbpAspNetCoreMvcUiBasicThemeModule),
        typeof(AbpAspNetCoreMvcUiAdminLTEThemeModule),
        typeof(AbpAspNetCoreAuthenticationJwtBearerModule),
        typeof(AbpTenantManagementWebModule),
        typeof(AbpAspNetCoreSerilogModule)
        )]
    public class AbpThemeAdminLteWebModule : AbpModule
````

Let's set **VirtualFileSystem** for the source files of AdminLTE theme such as css, js, image. For this, `AbpThemeAdminLte.Web.AbpThemeAdminLteWebModule.cs` in the file. Let's add to the `ConfigureVirtualFileSystem` method:

````chasrp
private void ConfigureVirtualFileSystem(IWebHostEnvironment hostingEnvironment)
        {
            if (hostingEnvironment.IsDevelopment())
            {
                Configure<AbpVirtualFileSystemOptions>(options =>
                {
                    options.FileSets.ReplaceEmbeddedByPhysical<AbpThemeAdminLteDomainSharedModule>(Path.Combine(hostingEnvironment.ContentRootPath, $"..{Path.DirectorySeparatorChar}AbpThemeAdminLte.Domain.Shared"));
                    options.FileSets.ReplaceEmbeddedByPhysical<AbpThemeAdminLteDomainModule>(Path.Combine(hostingEnvironment.ContentRootPath, $"..{Path.DirectorySeparatorChar}AbpThemeAdminLte.Domain"));
                    options.FileSets.ReplaceEmbeddedByPhysical<AbpThemeAdminLteApplicationContractsModule>(Path.Combine(hostingEnvironment.ContentRootPath, $"..{Path.DirectorySeparatorChar}AbpThemeAdminLte.Application.Contracts"));
                    options.FileSets.ReplaceEmbeddedByPhysical<AbpThemeAdminLteApplicationModule>(Path.Combine(hostingEnvironment.ContentRootPath, $"..{Path.DirectorySeparatorChar}AbpThemeAdminLte.Application"));
                    options.FileSets.ReplaceEmbeddedByPhysical<AbpThemeAdminLteWebModule>(hostingEnvironment.ContentRootPath);

                    // AdminLTE teması
                    options.FileSets.ReplaceEmbeddedByPhysical<AbpThemeAdminLteApplicationModule>(Path.Combine(hostingEnvironment.ContentRootPath, $"..{Path.DirectorySeparatorChar}..{Path.DirectorySeparatorChar}Abp.AspNetCore.Mvc.UI.Theme.AdminLTE"));
                });
            }
        }
````

Let's **Build** the project.

Let's run the `AbpThemeAdminLte.DbMigrator` and `AbpThemeAdminLte.Web` project.

![login](screenshots/login.png)

![home](screenshots/home.png)

![user-management](screenshots/user-management.png)

![user-management-permissions](screenshots/user-management-permissions.png)

![account-manage](screenshots/account-manage.png)




**Version Update**

Active version

> ABP v3.2.0

You just need to update the versions of ABP packages in the theme project file `Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.csproj`.

![theme-abp-package-references](screenshots/theme-abp-package-references.png)
