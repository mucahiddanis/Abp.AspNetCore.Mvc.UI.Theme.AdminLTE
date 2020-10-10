using Volo.Abp.TenantManagement;

namespace Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Pages.TenantManagement.Tenants
{
    public class CreateModalModel : Volo.Abp.TenantManagement.Web.Pages.TenantManagement.Tenants.CreateModalModel
    {
        public CreateModalModel(ITenantAppService tenantAppService) : base(tenantAppService)
        {
        }
    }
}
