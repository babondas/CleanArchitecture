using BioDnaLab.Domain.Entity.Account;
using BioDnaLab.Domain.Entity.Test;
using BioDnaLab.Domain.Entity.Test.TestSubEntities;
using BioDnaLab.Domain.Entity.TestPackage;
using BioDnaLab.Domain.Entity.TestPackage.JunctionTable;
using BioDnaLab.Domain.Entity.TestPackage.TestPackageSubEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BioDnaLab.Infrastructure.Data
{
    public class BioDnaLabContext : DbContext
    {
        public BioDnaLabContext(DbContextOptions<BioDnaLabContext> dbContextOptions) 
            : base(dbContextOptions)
        {

        }
        public DbSet<AccountEntity> Account { get; set; }

        //Test
        public DbSet<TestEntity> Test { get; set; }
        public DbSet<TestVolumeEntity> TestVolume { get; set; }
        public DbSet<TestMethodologyEntity> TestMethodology { get; set; }
        public DbSet<TestReportEntity> TestReport { get; set; }
        public DbSet<TestSampleEntity> TestSample { get; set; }
        public DbSet<TestScheduleEntity> TestSchedule { get; set; }
        public DbSet<TestStorageEntity> TestStorage { get; set; }
        
        

        //Test Package
        public DbSet<TestPackageFirstNameEntity> TestPackageFirstName { get; set; }
        public DbSet<TestPackageEntity> TestPackage { get; set; }

        public DbSet<TestPackageWithTestEntity> TestPackageWithTests { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TestEntity>(entity =>
            {
                //Set primary key
                entity.HasKey(e => e.Id); // Primary key
                entity.Property(e => e.Id)
                      .UseIdentityColumn(); // Identity column for Test

                //Set forign key relationship
                // Configure one-to-one relationship with TestVolume
                entity.HasOne(p => p.TestVolume)
                      .WithOne()
                      .HasForeignKey<TestEntity>(p => p.RefTestVolumeId);

                // Configure one-to-one relationship with TestMethodology
                entity.HasOne(p => p.TestMethodology)
                      .WithOne()
                      .HasForeignKey<TestEntity>(p => p.RefTestMethodologyId);

                // Configure one-to-one relationship with TestReport
                entity.HasOne(p => p.TestReport)
                      .WithOne()
                      .HasForeignKey<TestEntity>(p => p.RefTestReportId);

                // Configure one-to-one relationship with TestSample
                entity.HasOne(p => p.TestSample)
                      .WithOne()
                      .HasForeignKey<TestEntity>(p => p.RefTestSampleId);

                // Configure one-to-one relationship with TestSchedule
                entity.HasOne(p => p.TestSchedule)
                      .WithOne()
                      .HasForeignKey<TestEntity>(p => p.RefTestScheduleId);

                // Configure one-to-one relationship with TestStorage
                entity.HasOne(p => p.TestStorage)
                      .WithOne()
                      .HasForeignKey<TestEntity>(p => p.RefTestStorageId);
            });

           //Set primary key
            modelBuilder.Entity<TestVolumeEntity>(entity =>
            {
                entity.HasKey(e => e.Id); // Primary key
                entity.Property(e => e.Id)
                      .UseIdentityColumn(); // Identity column for Address
            });
            modelBuilder.Entity<TestMethodologyEntity>(entity =>
            {
                entity.HasKey(e => e.Id); // Primary key
                entity.Property(e => e.Id)
                      .UseIdentityColumn(); // Identity column for Address
            });
            modelBuilder.Entity<TestReportEntity>(entity =>
            {
                entity.HasKey(e => e.Id); // Primary key
                entity.Property(e => e.Id)
                      .UseIdentityColumn(); // Identity column for Address
            });
            modelBuilder.Entity<TestVolumeEntity>(entity =>
            {
                entity.HasKey(e => e.Id); // Primary key
                entity.Property(e => e.Id)
                      .UseIdentityColumn(); // Identity column for Address
            });
            modelBuilder.Entity<TestSampleEntity>(entity =>
            {
                entity.HasKey(e => e.Id); // Primary key
                entity.Property(e => e.Id)
                      .UseIdentityColumn(); // Identity column for Address
            });
            modelBuilder.Entity<TestScheduleEntity>(entity =>
            {
                entity.HasKey(e => e.Id); // Primary key
                entity.Property(e => e.Id)
                      .UseIdentityColumn(); // Identity column for Address
            });
            modelBuilder.Entity<TestStorageEntity>(entity =>
            {
                entity.HasKey(e => e.Id); // Primary key
                entity.Property(e => e.Id)
                      .UseIdentityColumn(); // Identity column for Address
            });


            modelBuilder.Entity<TestPackageEntity>(entity =>
            {
                //Set primary key
                entity.HasKey(e => e.Id); // Primary key
                entity.Property(e => e.Id)
                      .UseIdentityColumn(); // Identity column for Person

                //Set forign key relationship
                // Configure one-to-one relationship with TestVolume
                entity.HasOne(p => p.TestPackageFirstName)
                      .WithOne()
                      .HasForeignKey<TestPackageEntity>(p => p.RefTestPackageFirstNameId);
            });


            //Set primary key
            modelBuilder.Entity<TestPackageFirstNameEntity>(entity =>
            {
                entity.HasKey(e => e.Id); // Primary key
                entity.Property(e => e.Id)
                      .UseIdentityColumn(); // Identity column for Address
            });

            //TestPackage Junction Table
            modelBuilder.Entity<TestPackageWithTestEntity>(entity =>
            {
                //Set primary key
                entity.HasKey(e => e.Id); // Primary key
                entity.Property(e => e.Id)
                      .UseIdentityColumn(); // Identity column for TestPackageWithTests

                //Set forign key relationship
                // Configure one-to-one relationship with TestVolume
                entity.HasOne(p => p.TestEntity)
                      .WithOne()
                      .HasForeignKey<TestPackageWithTestEntity>(p => p.RefTestId);

                //Set forign key relationship
                // Configure one-to-one relationship with TestVolume
                entity.HasOne(p => p.TestPackageEntity)
                      .WithOne()
                      .HasForeignKey<TestPackageWithTestEntity>(p => p.RefTestPackageId);
            });

        }
    }
}
