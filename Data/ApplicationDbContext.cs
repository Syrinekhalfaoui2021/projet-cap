using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace CE.Data
{

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IHttpContextAccessor httpContextAccessor)
        : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public DbSet<RoleMenuPermission> RoleMenuPermission { get; set; }

        public DbSet<NavigationMenu> NavigationMenu { get; set; }
        public DbSet<Outlets> Outletss { get; set; }
        public DbSet<Visits> Visits { get; set; }
        public DbSet<Visitsweekly> Visitssweekly { get; set; }
        public DbSet<Visitsmonthly> Visitssmonthly { get; set; }
        public DbSet<models> Modelss { get; set; }
        protected UserManager<ApplicationUser> UserManager { get; set; }

        public DbSet<SammaryReport> sammaryReports { get; set; }
        public DbSet<brands> Brands { get; set; }
        public DbSet<SammaryReportMonthly> sammaryReportMonthlies { get; set; }
        public DbSet<SammaryReportWeekly> sammaryReportWeeklies { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<RoleMenuPermission>()
            .HasKey(c => new { c.RoleId, c.NavigationMenuId });


            base.OnModelCreating(builder);

            builder.Entity<models>()
                .HasDiscriminator<string>("models_type")
                .HasValue<models>("models_base")
                .HasValue<WM>("models_wm")
                .HasValue<AC>("models_AC")
                .HasValue<REF>("models_ref")
                .HasValue<TV>("models_TV");
            builder.Entity<SammaryReport>()
               .HasDiscriminator<string>("SammaryReport_type")
               .HasValue<SammaryReport>("SammaryReport_base")
               .HasValue<SammaryReportWeekly>("SammaryReport_SammaryReportWeekly")
               .HasValue<SammaryReportMonthly>("SammaryReport_AC")
               ;

        }
    }


}