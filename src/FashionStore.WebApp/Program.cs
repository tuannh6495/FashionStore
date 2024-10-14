using AutoMapper;
using FashionStore.Application.Interfaces;
using FashionStore.Application.Mapping;
using FashionStore.Application.Services;
using FashionStore.Domain.Interfaces;
using FashionStore.Infrastructure.Data;
using FashionStore.Infrastructure.Identity;
using FashionStore.Infrastructure.Repositories;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

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

builder.Services.AddDbContext<AccountDbContext>(options =>
	options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Đăng ký dịch vụ Identity với AppUser và IdentityRole
builder.Services.AddIdentity<UserAccount, IdentityRole>()
	.AddEntityFrameworkStores<AccountDbContext>()
	.AddDefaultTokenProviders();


// Cấu hình tùy chỉnh cho IdentityOptions
builder.Services.Configure<IdentityOptions>(options =>
{
	// Thiết lập về Password
	options.Password.RequireDigit = false;                    // Không bắt buộc phải có số
	options.Password.RequireLowercase = false;                // Không bắt buộc phải có chữ thường
	options.Password.RequireNonAlphanumeric = false;          // Không bắt buộc ký tự đặc biệt
	options.Password.RequireUppercase = false;                // Không bắt buộc chữ in hoa
	options.Password.RequiredLength = 3;                      // Độ dài tối thiểu của mật khẩu
	options.Password.RequiredUniqueChars = 1;                 // Số ký tự riêng biệt trong mật khẩu

	// Cấu hình Lockout - khóa người dùng sau nhiều lần đăng nhập sai
	options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5); // Khóa trong 5 phút
	options.Lockout.MaxFailedAccessAttempts = 5;                       // Sau 5 lần đăng nhập thất bại
	options.Lockout.AllowedForNewUsers = true;                         // Cho phép khóa với người dùng mới

	// Cấu hình về User
	options.User.AllowedUserNameCharacters =
		"abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
	options.User.RequireUniqueEmail = true;  // Bắt buộc email phải là duy nhất

	// Cấu hình đăng nhập
	options.SignIn.RequireConfirmedEmail = true;            // Bắt buộc xác nhận email
	options.SignIn.RequireConfirmedPhoneNumber = false;     // Không bắt buộc xác nhận số điện thoại
});

builder.Services.AddRazorPages();


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

// Thêm xác thực và ủy quyền vào pipeline
app.UseAuthentication();  // Phục hồi thông tin đăng nhập (xác thực)
app.UseAuthorization();   // Phục hồi thông tin về quyền của người dùng


app.MapRazorPages();

app.Run();
