using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using University.Core.DataInterface;

namespace University.Data.JsonFile
{
    public static class IServiceCollectionExtensions
    {

        public static void RegisterJsonFilesDataAccessClasses(this IServiceCollection services, String dataDirectory)
        {
            services.AddSingleton<IGradeRepository>(serviceProvider => new GradeRepository(dataDirectory));
            services.AddSingleton<ISemesterRepository>(serviceProvider => new SemesterRepository(dataDirectory));
            services.AddSingleton<ITermRepository>(serviceProvider => new TermRepository(dataDirectory));
            services.AddSingleton<IDepartmentRepository>(serviceProvider => new DepartmentRepository(dataDirectory));
            services.AddSingleton<ICourseRepository>(serviceProvider => new CourseRepository(dataDirectory));

        }


    }
}
