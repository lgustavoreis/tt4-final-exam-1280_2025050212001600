using Microsoft.EntityFrameworkCore;
using StudentAttendanceApi.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=student_attendance.db"));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); // Swagger
builder.Services.AddCors();

var app = builder.Build();

app.UseSwagger();                // Swagger
app.UseSwaggerUI();             // Swagger
app.UseCors(x => x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
app.UseAuthorization();
app.MapControllers();
app.Run();
