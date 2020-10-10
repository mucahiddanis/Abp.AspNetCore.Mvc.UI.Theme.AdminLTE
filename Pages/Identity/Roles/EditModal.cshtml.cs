using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Identity;
using Volo.Abp.Identity.Web.Pages.Identity;
using Volo.Abp.ObjectExtending;
using Volo.Abp.Validation;

namespace Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Identity.Roles
{
    public class EditModalModel : Volo.Abp.Identity.Web.Pages.Identity.Roles.EditModalModel
    {
        public EditModalModel(IIdentityRoleAppService identityRoleAppService) : base(identityRoleAppService)
        {
        }
    }
}