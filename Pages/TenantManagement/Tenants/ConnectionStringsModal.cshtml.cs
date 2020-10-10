using Volo.Abp.TenantManagement;

namespace Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Pages.TenantManagement.Tenants
{
    public class ConnectionStringsModal : Volo.Abp.TenantManagement.Web.Pages.TenantManagement.Tenants.ConnectionStringsModal
    {
        public ConnectionStringsModal(ITenantAppService tenantAppService) : base(tenantAppService)
        {
        }
    }
}
