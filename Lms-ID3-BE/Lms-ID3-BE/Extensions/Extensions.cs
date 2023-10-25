using Lms_ID3_BE.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Lms_ID3_BE.Extensions
{
  public static class Extensions
  {
    public static IServiceCollection AddDbContext(this IServiceCollection services, IConfiguration configuration)
    {
      services.AddDbContext<ID3DatabaseContext>(x => x.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

      AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
      AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
      return services;
    }

    public static IServiceCollection AddLogger(this IServiceCollection services, IConfiguration configuration)
    {
      //services.AddLogging(loggingBuilder =>
      //{
      //  loggingBuilder.AddSeq(configuration.GetSection("Seq"));
      //});
      return services;
    }

    public static IServiceCollection AddAutoMapperConfig(this IServiceCollection services)
    {
      services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);
      return services;
    }
  }
}
