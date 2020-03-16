namespace FundooApp
{
    using Manager.IManager;
    using Manager.Manager;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Repository.Context;
    using Repository.IRepository;
    using Repository.RepositoryClasses;
    using Swashbuckle.AspNetCore.Swagger;

    /// <summary>
    /// Start class used to add dependencies
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Startup"/> class.
        /// </summary>
        /// <param name="configuration">The configuration.</param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        /// Gets the configuration.
        /// </summary>
        /// <value>
        /// The configuration.
        /// </value>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// Configures the services.
        /// </summary>
        /// <param name="services">The services.</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<IAccountManager, AccountManager>();
            services.AddDbContext<UserContext>(options => options.UseSqlServer(Configuration.GetConnectionString("UserDBConncetion")));

            //services.AddCors(OP => OP.AddPolicy("Polices", builder =>
            //{
            //    builder.AllowAnyOrigin();
            //    builder.AllowAnyHeader();
            //    builder.AllowAnyMethod();
            //}));
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "Fundoo Note API",
                    Description = "My First ASP.NET Core Web API",
                });
            });

        }

        /// <summary>
        /// Configures the specified application.
        /// </summary>
        /// <param name="app">The application.</param>
        /// <param name="env">The env.</param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "FUNDOO NOTE API");
                });
            }
            else
            {
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}