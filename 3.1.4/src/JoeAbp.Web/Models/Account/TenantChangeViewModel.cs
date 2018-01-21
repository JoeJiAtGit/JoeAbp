using Abp.AutoMapper;
using JoeAbp.Sessions.Dto;

namespace JoeAbp.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}