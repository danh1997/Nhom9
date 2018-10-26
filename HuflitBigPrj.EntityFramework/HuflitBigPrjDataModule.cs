using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using HuflitBigPrj.EntityFramework;

namespace HuflitBigPrj
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(HuflitBigPrjCoreModule))]
    public class HuflitBigPrjDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<HuflitBigPrjDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
