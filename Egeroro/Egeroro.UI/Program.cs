using Egeroro.Data.Abstract;
using Egeroro.Data.Concrete;
using Egeroro.Data.EntityFramework;
using Egeroro.Entity.Identity;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<Context>();
builder.Services.AddScoped<IAboutUsDal, EFAboutUsDal>();
builder.Services.AddScoped<IContactDal, EFContactDal>();
builder.Services.AddScoped<IFleetDal, EFFleetDal>();
builder.Services.AddScoped<IGalleryDal, EFGalleryDal>();
builder.Services.AddScoped<IOurExpertiseDal, EFOurExpertiseDal>();
builder.Services.AddScoped<IOurServicesDal, EFOurServicesDal>();
builder.Services.AddScoped<IOurTeamDal, EFOurTeamDal>();

// Identity (Kimlik) Dogrulama
builder.Services.AddIdentity<AppUser, AppRole>(option =>
{
    option.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(15); // Kilitleme Suresi
    option.Lockout.MaxFailedAccessAttempts = 5; // Max basarisiz giris
    option.Password.RequireDigit = false; // Rakam zorunlulugu kaldirma
    option.Password.RequireNonAlphanumeric = false; // Ozel karakter zorunlulugu kaldirma
    option.Password.RequireLowercase = false; // Kucuk harf zorunlulugunu kaldirma
    option.Password.RequireUppercase = false; // Buyuk harf zorunlulugunu kaldirma
}).AddEntityFrameworkStores<Context>() // EF ile veri tabanı baglantisini saglar
.AddDefaultTokenProviders(); // Varsayilan token saglayicilarini ekler

// Cerezler (Cookies)
builder.Services.ConfigureApplicationCookie(option =>
{
    option.LoginPath = "/Admin/Login"; // Giris yapilmadiginda yonlendirilmesi gereken sayfa
    option.AccessDeniedPath = "/"; // Yetkisiz erisim oldugunda yonlendirilecek sayfa
    option.Cookie = new CookieBuilder()
    {
        Name = "AspNetCoreIdentityExampleCookie", // Cerez ismi
        HttpOnly = false, // Cerez http
        SameSite = SameSiteMode.Lax, // Cerez ayni sitede yapilacak isteklerde gecerli
        SecurePolicy = CookieSecurePolicy.Always // Cerez sadece SSL sertifikasi olan istekler uzerinden iletilir
    };
    option.SlidingExpiration = true; // Cerez gecerlilik suresi doldukca yenilenir
    option.ExpireTimeSpan = TimeSpan.FromMinutes(2); // Cerez gecerlilik suresi
});

builder.Services.AddSession();


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

app.UseRouting();

app.UseAuthentication(); // Kimlik dogrulama islemleri
app.UseAuthorization(); // Yetkilendirme islemleri
app.UseSession(); // Oturum yonetimini aktiflestirir

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

