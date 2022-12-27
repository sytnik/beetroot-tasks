var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<NewDbContext>(options =>
    options.UseSqlServer(Settings.ConnectionString));
builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.MapGet("/department", async (ICompanyRepository company) =>
    JsonSerializer.Serialize(await company.GetDepartmentAsync(), Settings.SerializerOptions));
app.MapPost("adduser", async (UserModel user, ICompanyRepository company) =>
    await company.AddUserAsync(user));
app.Run();