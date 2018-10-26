using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using HuflitBigPrj.EntityFramework;

namespace HuflitBigPrj.Migrator
{
    [DependsOn(typeof(HuflitBigPrjDataModule))]
    public class HuflitBigPrjMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<HuflitBigPrjDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}