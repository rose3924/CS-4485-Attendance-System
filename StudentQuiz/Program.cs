// Olivia Anderson

using Microsoft.EntityFrameworkCore;
using StudentQuiz.Components;
using StudentQuiz.Components.Service;
using StudentQuiz.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddServerSideBlazor();

///////////////////////////////////////////////////////////////
/// Settings for the database
// Load configuration from appsettings.json and secrets.json
builder.Configuration.AddUserSecrets<Program>();
builder.Services.AddHttpContextAccessor();

// Configure DbContext with connection string from appsettings.json
builder.Services.AddDbContext<FelixDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DatabaseConnection")));
///////////////////////////////////////////////////////////////

builder.Services.AddScoped<QuizRegistration>();
builder.Services.AddScoped<UserState>();
builder.Services.AddScoped<QuizResult>();
builder.Services.AddDistributedMemoryCache();
// Begin test
// Configure cookie policy
builder.Services.Configure<CookiePolicyOptions>(options =>
{
    options.MinimumSameSitePolicy = SameSiteMode.Lax;
    options.Secure = CookieSecurePolicy.Always;
});

// Add Session services with HttpOnly and Secure attributes
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); // Valid for 30 minutes of inactivity
    options.Cookie.HttpOnly = true; // Prevents access to cookies via client-side scripts
    options.Cookie.SecurePolicy = CookieSecurePolicy.Always; // Ensures cookies are sent over HTTPS
    options.Cookie.SameSite = SameSiteMode.Lax; // Allows navigation across pages
    options.Cookie.Name = ".MyStudentQuizzes.Session"; // Use a unique name
});

// Add Antiforgery services
builder.Services.AddAntiforgery(options =>
{
    options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
    options.Cookie.SameSite = SameSiteMode.None;
});

var app = builder.Build();

app.UseSession();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
