using System.Collections.Generic;

namespace Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.ProfileManagement
{
    public class ProfileManagementPageOptions
    {
        public List<IProfileManagementPageContributor> Contributors { get; }

        public ProfileManagementPageOptions()
        {
            Contributors = new List<IProfileManagementPageContributor>();
        }
    }
}
