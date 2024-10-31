
using DataAccessManagement.AppSettingClasses;
using DataAccessManagement.Entity;
using DataAccessManagement.MainDataBase;
using IntelligentInventoryManagement.IServiceCollectionExtension;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;

namespace IntelligentInventoryManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();
            /*******************Configure Database and Identity*************************/
            #region Configure DB and Identity
            builder.Services.AddDbContext<InventoryManagementDB>(op =>
            {
                op.UseSqlServer(builder.Configuration.GetConnectionString("default"));
            });
            builder.Services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<InventoryManagementDB>();
            #endregion
            /*********************Add Repository************************************/
            #region Registing Repositories
            builder.Services.AddReadRepositories(); 
            builder.Services.AddWriteRepositories();
            builder.Services.AddBulkRepository();
            #endregion
            /*************************Strong Type of AppSetting.json*****************/
            #region Strong Type of AppSetting.json
            builder.Services.Configure<JwtSetting>(builder.Configuration.GetSection("JwtSetting"));
            #endregion
            /*************************Add Authentication (Bearer Token)*****************/
            var stringKey = builder.Configuration.GetSection("JwtSetting").GetValue<string>("Key");
            var key64 =Convert.FromBase64String(stringKey);
            var key = new SymmetricSecurityKey(key64);
            #region 
            builder.Services.AddAuthentication(op => {
            op.DefaultAuthenticateScheme=JwtBearerDefaults.AuthenticationScheme;
                op.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(op => {
                op.TokenValidationParameters = new TokenValidationParameters { 
                IssuerSigningKey = key,
                ValidateIssuer = false,
                ValidateAudience = false,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ClockSkew = TimeSpan.FromSeconds(5) , 
                RoleClaimType=ClaimTypes.Role ,
                    ValidAlgorithms = new[] { SecurityAlgorithms.HmacSha256 }
                };
            });
            #endregion
            /***************************Allow Cors AnyRegion***************************/
            #region Cors
           
            #endregion

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
