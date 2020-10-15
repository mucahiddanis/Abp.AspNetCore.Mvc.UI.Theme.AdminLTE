using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.ProfileManagement;

namespace Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Pages.Account
{
    public class ManageModel : AccountPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public string ReturnUrl { get; set; }
        
        public ProfileManagementPageCreationContext ProfileManagementPageCreationContext { get; private set; }

        protected ProfileManagementPageOptions Options { get; }

        public ManageModel(IOptions<ProfileManagementPageOptions> options)
        {
            Options = options.Value;
        }

        public virtual async Task<IActionResult> OnGetAsync()
        {
            ProfileManagementPageCreationContext = new ProfileManagementPageCreationContext(ServiceProvider);

            foreach (var contributor in Options.Contributors)
            {
                await contributor.ConfigureAsync(ProfileManagementPageCreationContext);
            }

            return Page();
        }

        public virtual Task<IActionResult> OnPostAsync()
        {
            return Task.FromResult<IActionResult>(Page());
        }
    }
}
