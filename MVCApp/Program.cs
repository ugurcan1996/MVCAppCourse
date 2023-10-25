using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews(); // uygulama Mvc �aablonu ile �al��s�n

builder.Services.AddAuthentication(/*CookieAuthenticationDefaults.AuthenticationScheme*/"YZL3439")
    .AddCookie("YZL3439", option => //Uygulama cookie �zerinden imlik do�rulama yaps�n.
{
    option.LoginPath = "/Account/Login"; //Uygulama login sayfas�ndan s�recine devam etsin.
});

// Razor Pages Proje Template
// MVC Web Application Proje Template
// API Web Servis geli�tireme Proje Template
// Blazor Web Application Template

var app = builder.Build();

app.UseStaticFiles();  //wwwroot alt�ndaki css,js dosyalar�na        g�venmesi i�in

app.UseRouting(); // uygulama da y�nlendirme i�lemleri �al��s�n.
// uygulama ilk a��ld���nda anasayfadan a��lmas� i�in a�a��daki kural� yazd�k.

app.UseAuthentication(); //Sistemde login s�reci varsa authentication middleware     yaz�yoruz.
app.UseAuthorization(); //Authorize attiribute �al��s�n diye, yetkilendirme middleware

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"); // uygulamadan gelen istekler controllera y�nlendirilsin ayar� yapt�k.
app.Run();
