var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); // mvc �ablolunu ekler.
var app = builder.Build();


app.UseStaticFiles();


app.UseRouting();

// controller/action/id �emas�n� kullan�r.
app.MapDefaultControllerRoute();    // uzunhalinide kullanabikiriz. haz�r �aplondaki

app.Run();
