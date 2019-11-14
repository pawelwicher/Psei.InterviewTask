using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Psei.InterviewTask.Web.Configuration;
using Psei.InterviewTask.Web.DataAccess;
using Psei.InterviewTask.Web.Mappers;
using Psei.InterviewTask.Web.Repository;

namespace Psei.InterviewTask.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSwagger();

            services.AddDbContext<StudentsDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IDepartmentDtoMapper, DepartmentDtoMapper>();

            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseMvc().AddSwagger();
        }
    }
}