using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manager.IManager;
using Manager.Manager;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Model.UserModel;
using Repository.Context;
using Repository.IRepository;
using Repository.RepositoryClasses;
using Swashbuckle.AspNetCore.Filters;
using Swashbuckle.AspNetCore.Swagger;

namespace BookStore
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDbContextPool<UserContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("UserDBConncetion")));
            services.AddTransient<UserContext>();
            services.AddTransient<IBookStore, BookRepo>();
            services.AddTransient<IBooksManager, BooksManger>();
            services.AddTransient<ICartRepo, CartRepository>();
            services.AddTransient<ICartManager, CartManager>();
            services.AddTransient<ICustomerRepo, CustomerRepo>();
            services.AddTransient<ICustomerManager, CustomerManager>();
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<IOrdreManager, OrderManager>();
            services.AddTransient<IWishListManager, WishListManager>();
            services.AddTransient<IWishListRepo, WishListRepo>();
            services.AddIdentity<Users, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 8;
            }).AddEntityFrameworkStores<UserContext>().AddDefaultTokenProviders();
            services.Configure<DataProtectionTokenProviderOptions>(opt =>
           opt.TokenLifespan = TimeSpan.FromHours(2));

            var key = Configuration["Jwt:secretKey"];
            var symmetricKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            services.AddAuthentication(op =>
            {
                op.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                op.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(op =>
            {
                op.SaveToken = true;
                op.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateAudience = true,
                    ValidateIssuer = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = Configuration["Jwt:url"],
                    ValidAudience = Configuration["Jwt:url"],
                    IssuerSigningKey = symmetricKey,
                    RequireExpirationTime = true
                };
            });
            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin();
                builder.AllowAnyMethod();
                builder.AllowAnyHeader();
            }));
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Swashbuckle.AspNetCore.Swagger.Info
                {
                    Version = "v1",
                    Title = "My Fundoo Note API",
                });

                c.AddSecurityDefinition("oauth2", new ApiKeyScheme
                {
                    Description = "Jwt bearer token",
                    Name = "Authorization",
                    In = "header",
                    Type = "apiKey"
                });
                c.OperationFilter<SecurityRequirementsOperationFilter>();

            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseCors("MyPolicy");
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.UseAuthentication();
            app.UseHttpsRedirection();
            app.UseMvc();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My Book Store API");
            });
        }
    }
}
