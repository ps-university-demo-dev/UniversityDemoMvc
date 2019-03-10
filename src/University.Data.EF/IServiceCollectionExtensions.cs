using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using University.Core.DataInterface;
using University.Data.EF.Repositories;

namespace University.Data.EF
{
    public static class IServiceCollectionExtensions
    {

        public static void ConfigureSqlLiteDatabase(this IServiceCollection services, String connectionString)
        {
            // Configures the contest
            var connection = new SqliteConnection(connectionString);
            connection.Open();

            services.AddDbContext<UniversityContext>(options =>
                options.UseSqlite(connection)
            );

            // Make sure the database exists
            var builder = new DbContextOptionsBuilder<UniversityContext>();
            builder.UseSqlite(connection);

            using (var context = new UniversityContext(builder.Options))
            {
                context.Database.EnsureCreated();                
            }
        }


        public static void ConfigureRepositories(this IServiceCollection services)
        {
            services.AddScoped<ISemesterRepository, SemesterRepository>();
            services.AddScoped<ITermRepository, TermRepository>();

            services.AddScoped<IGradeRepository, GradeRepository>();

            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            services.AddScoped<ICourseRepository, CourseRepository>();

        }


    }
}
