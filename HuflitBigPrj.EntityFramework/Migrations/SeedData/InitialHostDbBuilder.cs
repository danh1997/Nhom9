using HuflitBigPrj.EntityFramework;
using EntityFramework.DynamicFilters;

namespace HuflitBigPrj.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly HuflitBigPrjDbContext _context;

        public InitialHostDbBuilder(HuflitBigPrjDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
