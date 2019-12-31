using AutoMapper;
using Fluent.Infrastructure.FluentModel;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MongoDB.Bson;
using MotoBoy.Data;
using MotoBoy.Data.Implementation;
using MotoBoy.Data.Interface;
using MotoBoy.Domain;
using MotoBoy.IoC;
using MotoBoy.Service;
using MotoBoy.Service.Interface;
using MotoBoy.Service.Request;
using MotoBoy.Service.Response;
using MotoBoy.WebApi.Request;
using MotoBoy.WebApi.Responses;
using System;

namespace WebApi
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
            services.AddControllers();

            #region DI
            services.Add(new ServiceDescriptor(typeof(IDayResumeRepository), typeof(DayResumeRepository), ServiceLifetime.Transient));
            services.Add(new ServiceDescriptor(typeof(IDayResumeService), typeof(DayResumeService), ServiceLifetime.Transient));


            #endregion

            #region automapper
            var config = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.CreateMap<DayResumeServiceResponse, DayResumeResponse>();
                cfg.CreateMap<DayResumeServiceInsertRequest, DayResumeDomain>();
                cfg.CreateMap<DayResumeServiceUpdateRequest, DayResumeDomain>().ForMember(x => x.InternalId, y => y.MapFrom(w => new ObjectId(w.Id)));
                cfg.CreateMap<InsertDayResumeRequest, DayResumeServiceInsertRequest>();
                cfg.CreateMap<UpdateDayResumeRequest, DayResumeServiceUpdateRequest>();
                cfg.CreateMap<DayResumeDomain, DayResumeServiceInsertRequest>();
                cfg.CreateMap<DayResumeDomain, DayResumeServiceResponse>();
            });

            IMapper mapper = config.CreateMapper();

            services.AddSingleton(mapper);
            #endregion

            #region MongoDB
            MongoDbContext.ConnectionString = Configuration.GetSection("MongoConnection:ConnectionString").Value;
            MongoDbContext.DatabaseName = Configuration.GetSection("MongoConnection:Database").Value;
            MongoDbContext.IsSSL = Convert.ToBoolean(this.Configuration.GetSection("MongoConnection:IsSSL").Value);
            #endregion

            services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(Configuration.GetConnectionString("DefaultConnection")));

            services.AddDefaultIdentity<ApplicationUser>()
                .AddDefaultUI(UIFramework.Bootstrap4)
                .AddEntityFrameworkStores<ApplicationDbContext>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
