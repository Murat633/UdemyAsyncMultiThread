using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PLINQAPP.Models;

public partial class Addamsfa1AkContext : DbContext
{
    public Addamsfa1AkContext()
    {
    }

    public Addamsfa1AkContext(DbContextOptions<Addamsfa1AkContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Advert> Adverts { get; set; }

    public virtual DbSet<AdvertLike> AdvertLikes { get; set; }

    public virtual DbSet<BalanceOrder> BalanceOrders { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<CompanyAd> CompanyAds { get; set; }

    public virtual DbSet<CompanyLike> CompanyLikes { get; set; }

    public virtual DbSet<CompanyRating> CompanyRatings { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<PendingUpdateCompany> PendingUpdateCompanies { get; set; }

    public virtual DbSet<SiteSetting> SiteSettings { get; set; }

    public virtual DbSet<Town> Towns { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=104.247.162.242\\MSSQLSERVER2019;Initial Catalog=addamsfa1_ak;User ID=nakliy34_murat;Password=05070383598Mm./;Connect Timeout=30;MultipleActiveResultSets=true;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .HasDefaultSchema("nakliy34_murat")
            .UseCollation("SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<Advert>(entity =>
        {
            entity.ToTable("adverts", "dbo");

            entity.HasIndex(e => e.CategoryId, "IX_adverts_CategoryId");

            entity.Property(e => e.OfferPrice).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Category).WithMany(p => p.Adverts).HasForeignKey(d => d.CategoryId);
        });

        modelBuilder.Entity<AdvertLike>(entity =>
        {
            entity.ToTable("AdvertLike", "dbo");

            entity.HasIndex(e => e.AdvertId, "IX_AdvertLike_AdvertId");

            entity.HasOne(d => d.Advert).WithMany(p => p.AdvertLikes).HasForeignKey(d => d.AdvertId);
        });

        modelBuilder.Entity<BalanceOrder>(entity =>
        {
            entity.ToTable("BalanceOrder", "dbo");

            entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.ToTable("categories", "dbo");
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.ToTable("City", "dbo");

            entity.HasIndex(e => e.CountryId, "IX_City_CountryId");

            entity.HasOne(d => d.Country).WithMany(p => p.Cities).HasForeignKey(d => d.CountryId);
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.ToTable("companies", "dbo");

            entity.HasIndex(e => e.CategoryId, "IX_companies_CategoryId");

            entity.Property(e => e.Country).HasDefaultValue("");
            entity.Property(e => e.FailedMsg).HasDefaultValue("");

            entity.HasOne(d => d.Category).WithMany(p => p.Companies).HasForeignKey(d => d.CategoryId);

            entity.HasMany(d => d.Countries).WithMany(p => p.Companies)
                .UsingEntity<Dictionary<string, object>>(
                    "CompanyCountry",
                    r => r.HasOne<Country>().WithMany().HasForeignKey("CountriesId"),
                    l => l.HasOne<Company>().WithMany().HasForeignKey("CompaniesId"),
                    j =>
                    {
                        j.HasKey("CompaniesId", "CountriesId");
                        j.ToTable("CompanyCountry", "dbo");
                        j.HasIndex(new[] { "CountriesId" }, "IX_CompanyCountry_CountriesId");
                    });
        });

        modelBuilder.Entity<CompanyAd>(entity =>
        {
            entity.ToTable("companyAds", "dbo");

            entity.HasIndex(e => e.CompanyId, "IX_companyAds_CompanyId");

            entity.HasOne(d => d.Company).WithMany(p => p.CompanyAds).HasForeignKey(d => d.CompanyId);
        });

        modelBuilder.Entity<CompanyLike>(entity =>
        {
            entity.ToTable("CompanyLike", "dbo");

            entity.HasIndex(e => e.CompanyId, "IX_CompanyLike_CompanyId");

            entity.HasOne(d => d.Company).WithMany(p => p.CompanyLikes).HasForeignKey(d => d.CompanyId);
        });

        modelBuilder.Entity<CompanyRating>(entity =>
        {
            entity.ToTable("CompanyRating", "dbo");

            entity.HasIndex(e => e.CompanyId, "IX_CompanyRating_CompanyId");

            entity.HasOne(d => d.Company).WithMany(p => p.CompanyRatings).HasForeignKey(d => d.CompanyId);
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.ToTable("Country");

            entity.HasMany(d => d.PendingUpdateCompanies).WithMany(p => p.Countries)
                .UsingEntity<Dictionary<string, object>>(
                    "CountryPendingUpdateCompany",
                    r => r.HasOne<PendingUpdateCompany>().WithMany().HasForeignKey("PendingUpdateCompaniesId"),
                    l => l.HasOne<Country>().WithMany().HasForeignKey("CountriesId"),
                    j =>
                    {
                        j.HasKey("CountriesId", "PendingUpdateCompaniesId");
                        j.ToTable("CountryPendingUpdateCompany");
                        j.HasIndex(new[] { "PendingUpdateCompaniesId" }, "IX_CountryPendingUpdateCompany_PendingUpdateCompaniesId");
                    });
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.ToTable("Notification");

            entity.Property(e => e.Status).HasDefaultValue("");
        });

        modelBuilder.Entity<PendingUpdateCompany>(entity =>
        {
            entity.ToTable("pendingUpdateCompany");

            entity.Property(e => e.IsSuccess).HasColumnName("isSuccess");
            entity.Property(e => e.IsUpdate).HasColumnName("isUpdate");
        });

        modelBuilder.Entity<SiteSetting>(entity =>
        {
            entity.ToTable("siteSetting");
        });

        modelBuilder.Entity<Town>(entity =>
        {
            entity.ToTable("Town");

            entity.HasIndex(e => e.CityId, "IX_Town_CityId");

            entity.HasOne(d => d.City).WithMany(p => p.Towns).HasForeignKey(d => d.CityId);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("users");

            entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
