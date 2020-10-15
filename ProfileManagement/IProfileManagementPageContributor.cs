using System.Threading.Tasks;

namespace Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.ProfileManagement
{
    public interface IProfileManagementPageContributor
    {
        Task ConfigureAsync(ProfileManagementPageCreationContext context);
    }
}
