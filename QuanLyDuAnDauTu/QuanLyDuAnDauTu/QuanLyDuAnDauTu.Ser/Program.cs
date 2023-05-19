using AutoMapper;
using Microsoft.EntityFrameworkCore;
using QuanLyDuAnDauTu.Ser.Extensions;
using QuanLyDuAnDauTu.Ser.Infrastructure;
using QuanLyDuAnDauTu.Ser.Services;

var builder = WebApplication.CreateBuilder(args);


//Add AutoMapper
var config = new MapperConfiguration(cfg =>
{
    cfg.AllowNullCollections = true;
    cfg.AddProfile(new MapperInitializer());
});
var mapper = config.CreateMapper();
builder.Services.AddSingleton(mapper);


// Add services to the container.
builder.Services.AddScoped<IDuAnService, DuAnService>();
builder.Services.AddScoped<IDanhMucService, DanhMucService>();






// Connect SQL
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
//builder.Services.AddDbContext<ApplicationDbContext>(x => x.UseSqlServer(connectionString, 
//    x=>x.EnableRetryOnFailure(
//         maxRetryCount: 5,
//         maxRetryDelay: System.TimeSpan.FromSeconds(30),
//         errorNumbersToAdd: null)
//    ));

builder.Services.AddDbContext<ApplicationDbContext>(x => x.UseSqlServer(connectionString
    ));




builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


// global cors policy
app.UseCors(x => x
    .AllowAnyMethod()
    .AllowAnyHeader()
    .SetIsOriginAllowed(origin => true) // allow any origin 
    .AllowCredentials());


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

app.Run();
