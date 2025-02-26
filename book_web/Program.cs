using book_web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using book_web.Middleware;
using book_web.Services;
using book_web.Dependency_Injection;
using book_web.Models;
using SendGrid.Helpers.Mail;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<Book_webContext>(options =>
options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddRazorPages();
builder.Services.AddSignalR();

builder.Services.AddDefaultIdentity<IdentityUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;

    // Configure lockout settings for blocking users
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromDays(365);
    options.Lockout.MaxFailedAccessAttempts = 3;
    options.Lockout.AllowedForNewUsers = true;
})
           .AddRoles<IdentityRole>()
           .AddEntityFrameworkStores<Book_webContext>();

builder.Services.AddScoped<IBookRecommendationService, BookRecommendationService>();
builder.Services.AddScoped<IContentFetchingService, ContentFetchingService>();
builder.Services.AddScoped<IEventServices,EventService>();
builder.Services.AddScoped<ICusService, CusService>();
builder.Services.AddScoped<IAboutUsService, AboutUsService>();
builder.Services.AddScoped<IEmailService, EmailService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IBookService>();
builder.Services.AddScoped<IBookRespository,BookRespository>();
builder.Services.AddTransient<IMailService, MailService>();

builder.Services.AddSession();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddCors(p => p.AddPolicy("CorsPolicy", builder => builder.WithOrigins("https://localhost:44337/").AllowAnyMethod().AllowAnyHeader()));
builder.Services.Configure<MailSettings>(builder.Configuration.GetSection("MailSettings"));



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseMiddleware<ActivityLoggingMiddleware>();
app.UseRouting();

app.UseAuthorization();
app.UseSession();
app.MapRazorPages();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapHub<ChatHub>("/chatHub");
app.MapHub<StatisticHub>("/statisticHub");
app.UseCors("CorsPolicy");
app.Run();
