using Abp.MultiTenancy;
using HuflitBigPrj.Authorization.Users;

namespace HuflitBigPrj.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {
            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}