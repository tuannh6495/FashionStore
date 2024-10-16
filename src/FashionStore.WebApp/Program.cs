using AutoMapper;
using FashionStore.Application.Interfaces;
using FashionStore.Application.Mapping;
using FashionStore.Application.Services;
using FashionStore.Domain.Entities;
using FashionStore.Domain.Interfaces;
using FashionStore.Infrastructure.Data;
using FashionStore.Infrastructure.Middleware;
using FashionStore.Infrastructure.Repositories;
using FashionStore.Infrastructure.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOptions();
var mailSettings = builder.Configuration.GetSection("MailSettings");
builder.Services.Configure<MailSettings>(mailSettings);

builder.Services.AddTransient<IEmailSender, SendMailService>();

builder.Services.AddRazorPages();
builder.Services.AddSession();

var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new MappingProfile()); 
});

IMapper mapper = mapperConfig.CreateMapper();

builder.Services.AddSingleton(mapper);

builder.Services.AddDbContext<FosDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IReviewRepository, ReviewRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ISizeRepository, SizeRepository>();
builder.Services.AddScoped<IColorRepository, ColorRepository>();
builder.Services.AddScoped<IDressStyleRepository, DressStyleRepository>();

builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IReviewService, ReviewService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ISizeService, SizeService>();
builder.Services.AddScoped<IColorService, ColorService>();
builder.Services.AddScoped<IDressStyleService, DressStyleService>();


builder.Services.AddIdentity<AppUser, IdentityRole>()
           .AddEntityFrameworkStores<FosDbContext>()
           .AddDefaultTokenProviders();

builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true; 
    options.Password.RequireNonAlphanumeric = false; 
    options.Password.RequireUppercase = true; 
    options.Password.RequiredLength = 6; 
    options.Password.RequiredUniqueChars = 1; 

    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
    options.Lockout.MaxFailedAccessAttempts = 5; 
    options.Lockout.AllowedForNewUsers = true;

    options.User.AllowedUserNameCharacters =
        "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
    options.User.RequireUniqueEmail = true; 

    options.SignIn.RequireConfirmedEmail = true; 
    options.SignIn.RequireConfirmedPhoneNumber = false; 
    options.SignIn.RequireConfirmedAccount = true;
});

builder.Services.ConfigureApplicationCookie(options => {
    options.LoginPath = "/Login";
    options.LogoutPath = "/Logout";
    options.AccessDeniedPath = "/Identity/Account/AccessDenied";
});

builder.Services.AddAuthentication(options =>
{
	options.DefaultAuthenticateScheme = IdentityConstants.ApplicationScheme;
	options.DefaultChallengeScheme = IdentityConstants.ApplicationScheme;
})
.AddGoogle(googleOptions =>
{
	IConfigurationSection googleAuthNSection = builder.Configuration.GetSection("Authentication:Google");

	googleOptions.ClientId = googleAuthNSection["ClientId"];
	googleOptions.ClientSecret = googleAuthNSection["ClientSecret"];

	googleOptions.CallbackPath = "/GoogleLogin";
});

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<FosDbContext>();

    try
    {
        FosDbContextSeed.Seed(context);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An error occurred during seeding: {ex.Message}");
    }
}


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection(); 
app.UseStaticFiles();

app.UseRouting();

app.UseMiddleware<ImageHandlerMiddleware>();

app.UseSession();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();


app.Run();
