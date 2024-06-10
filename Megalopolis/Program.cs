using Megalopolis.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.RegistrerDependencies();

builder.Services.AddDataBaseConection(builder.Configuration);
builder.Services.RegistrerDependencies();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

var app = builder.Build();

app.UseCors("CorsPolicy");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors(c =>
{
    c.AllowAnyHeader();
    c.AllowAnyMethod();
    c.AllowAnyOrigin();
});


app.MapControllers();

app.MapGet("/", () =>
{
    return $"Hello from {typeof(Program).Assembly.GetName().Name}!";
}).ExcludeFromDescription();

app.Run();
