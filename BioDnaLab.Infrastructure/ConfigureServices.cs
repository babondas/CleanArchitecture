using BioDnaLab.Domain.IRepository.IRepositoryCommand.IAccount;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest.ITestMethodology;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest.ITestReport;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest.ITestSample;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest.ITestSchedule;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest.ITestStorage;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest.ITestVolume;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITestPackage;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITestPackage.ITestPackageFirstName;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITestPackage.TestPackageWithTest;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.IAccount;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITest;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITest.ITestMethodology;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITest.ITestReport;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITest.ITestSample;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITest.ITestSchedule;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITest.ITestStorage;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITest.ITestVolume;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITestPackage;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITestPackage.ITestPackageFirstName;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITestPackage.TestPackageWithTest;
using BioDnaLab.Infrastructure.Data;
using BioDnaLab.Infrastructure.Repository.Command.Account;
using BioDnaLab.Infrastructure.Repository.Command.Test;
using BioDnaLab.Infrastructure.Repository.Command.Test.Methodology;
using BioDnaLab.Infrastructure.Repository.Command.Test.TestReport;
using BioDnaLab.Infrastructure.Repository.Command.Test.TestSample;
using BioDnaLab.Infrastructure.Repository.Command.Test.TestSchedule;
using BioDnaLab.Infrastructure.Repository.Command.Test.TestStorage;
using BioDnaLab.Infrastructure.Repository.Command.Test.TestVolume;
using BioDnaLab.Infrastructure.Repository.Command.TestPackage;
using BioDnaLab.Infrastructure.Repository.Command.TestPackage.TestPackageFirstName;
using BioDnaLab.Infrastructure.Repository.Command.TestPackage.TestPackageWithTest;
using BioDnaLab.Infrastructure.Repository.Query.Account;
using BioDnaLab.Infrastructure.Repository.Query.Test;
using BioDnaLab.Infrastructure.Repository.Query.Test.Methodology;
using BioDnaLab.Infrastructure.Repository.Query.Test.TestReport;
using BioDnaLab.Infrastructure.Repository.Query.Test.TestSample;
using BioDnaLab.Infrastructure.Repository.Query.Test.TestSchedule;
using BioDnaLab.Infrastructure.Repository.Query.Test.TestStorage;
using BioDnaLab.Infrastructure.Repository.Query.Test.TestVolume;
using BioDnaLab.Infrastructure.Repository.Query.TestPackage;
using BioDnaLab.Infrastructure.Repository.Query.TestPackage.TestPackageFirstName;
using BioDnaLab.Infrastructure.Repository.Query.TestPackage.TestPackageWithTest;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BioDnaLab.Infrastructure
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<BioDnaLabContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("BioDnaLabConnectionString") ?? 
                throw new InvalidOperationException("Connection string is 'BioDnaLabConnectionString' not found")
            ));

            // Account
            services.AddTransient<IAccountRepositoryCommand, AccountRepositoryCommand>();
            services.AddTransient<IAccountRepositoryQuey, AccountRepositoryQuery>();

            //Test
            services.AddTransient<ITestRepositoryCommand, TestRepositoryCommand>();
            services.AddTransient<ITestRepositoryQuery, TestRepositoryQuery>();

            services.AddTransient<ITestVolumeCommand, TestVolumeRepositoryCommand>();
            services.AddTransient<ITestVolumeQuery, TestVolumeRepositoryQuery>();


            services.AddTransient<ITestMethodologyCommand, MethodologyRepositoryCommand>();
            services.AddTransient<ITestMethodologyQuery, MethodologyRepositoryQuery>();

            services.AddTransient<ITestSampleCommand, TestSampleRepositoryCommand>();
            services.AddTransient<ITestSampleQuery, TestSampleRepositoryQuery>();

            services.AddTransient<ITestScheduleCommand, TestScheduleRepositoryCommand>();
            services.AddTransient<ITestScheduleQuery, TestScheduleRepositoryQuery>();

            services.AddTransient<ITestStorageCommand, TestStorageRepositoryCommand>();
            services.AddTransient<ITestStorageQuery, TestStorageRepositoryQuery>();

            services.AddTransient<ITestReportCommand, TestReportRepositoryCommand>();
            services.AddTransient<ITestReportQuery, TestReportRepositoryQuery>();

            //TestPackage
            services.AddTransient<ITestPackageFirstNameCommand, TestPackageFirstNameRepositoryCommand>();
            services.AddTransient<ITestPackageFirstNameNameQuery, TestPackageFirstNameRepositoryQuery>();

            services.AddTransient<ITestPackageRepositoryCommand, TestPackageRepositoryCommand>();
            services.AddTransient<ITestPackageRepositoryQuery, TestPackageRepositoryQuery>();

            services.AddTransient<ITestPackageWithTestRepositoryQuery, TestPackageWithTestRepositoryQuery>();
            services.AddTransient<ITestPackageWithTestRepositoryCommand, TestPackageWithTestRepositoryCommand>();

            return services;
        }
    }
}
//https://www.youtube.com/watch?v=Pa4YOCe7Ido