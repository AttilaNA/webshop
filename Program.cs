using WebShop.Others.Daos.Storage;
using WebShop.Others.Daos;
using WebShop.Others.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IProductDao, ProductStorage>();
builder.Services.AddSingleton<ICategoryDao, CategoryStorage>();
builder.Services.AddSingleton<ISupplierDao, SupplierStorage>();
builder.Services.AddSingleton<IWebShopService, WebShopService>();

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=WebShop}/{action=Index}/{id?}");

app.Run();
