using AutoMapper;
using FashionStore.Application.Interfaces;
using FashionStore.Application.Mapping;
using FashionStore.Application.Services;
using FashionStore.Domain.Interfaces;
using FashionStore.Infrastructure.Data;
using FashionStore.Infrastructure.Repositories;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSession();

var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new MappingProfile()); // Thêm các cấu hình ánh xạ
});

IMapper mapper = mapperConfig.CreateMapper();

// Đăng ký AutoMapper thủ công với DI container
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

//builder.Services.AddAutoMapper(typeof(Program));

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


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection(); 

app.UseStaticFiles();

app.UseRouting();

app.UseSession();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
