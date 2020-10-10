using AutoMapper;

namespace Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.AutoMapperProfiles
{
    public class AbpAspNetCoreMvcUiAdminLTETenantsAutoMapperProfile : Profile
    {
        public AbpAspNetCoreMvcUiAdminLTETenantsAutoMapperProfile()
        {
            //List
            CreateMap<Volo.Abp.TenantManagement.TenantDto, Pages.TenantManagement.Tenants.EditModalModel.TenantInfoModel>();

            //CreateModal
            CreateMap<Pages.TenantManagement.Tenants.CreateModalModel.TenantInfoModel, Volo.Abp.TenantManagement.TenantCreateDto>()
                .MapExtraProperties();

            //EditModal
            CreateMap<Pages.TenantManagement.Tenants.EditModalModel.TenantInfoModel, Volo.Abp.TenantManagement.TenantUpdateDto>()
                .MapExtraProperties();



        }
    }
}
