# Abp.AspNetCore.Mvc.UI.Theme.AdminLTE
ABP framework AdminLTE Theme


ABP framework ile geliştirilen AspNet MVC / Razor projeleri için AdminLTE temasıdır.

Öncelikle ABP CLI aracını aşağıdaki komutu kullanarak kuralım.

````shell
dotnet tool install -g Volo.Abp.Cli
````

Zaten yüklüyse aşağıdaki komutla güncelleyebilirsiniz:

````shell
dotnet tool update -g Volo.Abp.Cli
````

Temayı uygulamak için örnek yeni bir proje oluşturalım:

````shell
abp new AbpThemeAdminLteSample
````

Proje ana dizininde Tema projesi için **theme** isminde klasör oluşturalım ve komut satırında **theme** dizinine gidelim:

````shell
mkdir theme
cd theme
````

ABP için **AdminLTE** tema modülü projesini git üzerinden alalım:

````shell
git clone https://github.com/mucahiddanis/Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.git
````

Proje ana dizinine dönelim:

````shell
cd ..
cd ..
````

**sln** dosyasına AdminLTE tema projesini ekleyelim:

````shell
dotnet sln add theme/Abp.AspNetCore.Mvc.UI.Theme.AdminLTE/Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.csproj
````

`MyProject.Web` projemize AdminLTE tema projesini referans edelim:

````shell
<ProjectReference Include="..\..\theme\Abp.AspNetCore.Mvc.UI.Theme.AdminLTE\Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.csproj" />
````

`AbpThemeAdminLteSample.Web.AbpThemeAdminLteSampleWebModule.cs` web modülünde temamızı konfigüre edelim:

````csharp
[DependsOn(
        typeof(AbpThemeAdminLteSampleHttpApiModule),
        typeof(AbpThemeAdminLteSampleApplicationModule),
        typeof(AbpThemeAdminLteSampleEntityFrameworkCoreDbMigrationsModule),
        typeof(AbpAutofacModule),
        typeof(AbpIdentityWebModule),
        typeof(AbpAccountWebIdentityServerModule),
        typeof(AbpAspNetCoreMvcUiBasicThemeModule),
        typeof(AbpAspNetCoreAuthenticationJwtBearerModule),
        typeof(AbpTenantManagementWebModule),
        typeof(AbpAspNetCoreSerilogModule)
        )]
    public class AbpThemeAdminLteSampleWebModule : AbpModule
````


````csharp
typeof(AbpAspNetCoreMvcUiBasicThemeModule),
````

Yukarıdaki kodu aşağıdaki kod ile değiştirelim:

````csharp
typeof(AbpAspNetCoreMvcUiAdminLTEThemeModule),
````

modülün çözümlenmesi için **using** ekleyelim:

````csharp
using Abp.AspNetCore.Mvc.UI.Theme.AdminLTE;
````

**DependsOn** listesi son olarak şöyle olmalı:

````csharp
[DependsOn(
        typeof(AbpThemeAdminLteSampleHttpApiModule),
        typeof(AbpThemeAdminLteSampleApplicationModule),
        typeof(AbpThemeAdminLteSampleEntityFrameworkCoreDbMigrationsModule),
        typeof(AbpAutofacModule),
        typeof(AbpIdentityWebModule),
        typeof(AbpAccountWebIdentityServerModule),
        typeof(AbpAspNetCoreMvcUiAdminLTEThemeModule),
        typeof(AbpAspNetCoreAuthenticationJwtBearerModule),
        typeof(AbpTenantManagementWebModule),
        typeof(AbpAspNetCoreSerilogModule)
        )]
    public class AbpThemeAdminLteSampleWebModule : AbpModule
````


Projeyi **Build** edelim.

`AbpThemeAdminLteSample.DbMigrator` projesini çalıştıralım.
`AbpThemeAdminLteSample.Web` Projesini çalıştıralım.

![login](screenshots/login.png)

![home](screenshots/home.png)

![user-management](screenshots/user-management.png)

![user-management-permissions](screenshots/user-management-permissions.png)

![account-manage](screenshots/account-manage.png)



**Versiyon Güncelleme**

Aktif versiyon

> ABP v3.2.1

`Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.csproj` tema proje dosyasında ABP paketlerinin versiyonlarını güncellemeniz yeterli.

![theme-abp-package-references](screenshots/theme-abp-package-references.png)