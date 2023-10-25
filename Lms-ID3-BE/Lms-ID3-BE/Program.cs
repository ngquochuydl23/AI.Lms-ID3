using Lms_ID3_BE.Extensions;
using Lms_ID3_BE.Infrastructure.Repository;
using Lms_ID3_BE.Middlewares;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services
  .AddAutoMapperConfig()
  .AddDbContext(builder.Configuration);

builder.Services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddTransient(typeof(IRepository<>), typeof(Repository<>));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}
app.UseMiddleware<ErrorHandlingMiddleWare>();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.Run();
