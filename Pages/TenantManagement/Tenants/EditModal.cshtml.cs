using Volo.Abp.TenantManagement;

namespace Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Pages.TenantManagement.Tenants
{
    public class EditModalModel : Volo.Abp.TenantManagement.Web.Pages.TenantManagement.Tenants.EditModalModel
    {
        public EditModalModel(ITenantAppService tenantAppService) : base(tenantAppService)
        {
        }
    }
}