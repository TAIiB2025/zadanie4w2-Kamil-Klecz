




using BLL;
using BLL_Memory;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddScoped<IUslugiService, UslugiService>();
builder.Services.AddCors(corsBuilder => corsBuilder.AddPolicy("PolitykaCORS", policyBuilder =>
                        policyBuilder.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod().Build()));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();
app.UseCors("PolitykaCORS");
app.UseAuthorization();

app.MapControllers();

app.Run();
