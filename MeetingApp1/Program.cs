var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); // mvc þablolunu ekler.
var app = builder.Build();


app.UseStaticFiles();


app.UseRouting();

// controller/action/id þemasýný kullanýr.
app.MapDefaultControllerRoute();    // uzunhalinide kullanabikiriz. hazýr þaplondaki

app.Run();
