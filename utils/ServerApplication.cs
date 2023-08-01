namespace web_server.utils;

public static class ServerApplication
{
    private static WebApplication? _app;
    private static WebApplicationBuilder? _builder;

    public static void Start(string[] args)
    {
        _builder = WebApplication.CreateBuilder(args);

        // Add services to the container.  
        _builder.Services.AddControllers();

        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        _builder.Services.AddEndpointsApiExplorer();
        _builder.Services.AddSwaggerGen();
        _builder.Services.AddCors(options =>
        {
            options.AddPolicy("TestDomain",
                builder => builder.WithOrigins("http://localhost:5173").AllowAnyMethod().AllowAnyHeader());
        });

        _app = _builder.Build();

        // Configure the HTTP request pipeline.
        if (_app.Environment.IsDevelopment())
        {
            _app.UseSwagger()
                .UseSwaggerUI()
                .UseCors("TestDomain");
        }

        _app.UseHttpsRedirection()
            .UseAuthorization();
        _app.MapControllers();
        _app.Run();
    }
}