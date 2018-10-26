using Abp.AutoMapper;
using HuflitBigPrj.Sessions.Dto;

namespace HuflitBigPrj.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}