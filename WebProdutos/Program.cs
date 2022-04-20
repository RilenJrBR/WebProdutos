using Microsoft.EntityFrameworkCore;
using WebProdutos.Models;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();

builder.Services.AddEntityFrameworkNpgsql()
    .AddDbContext<ProdutoContext>(options =>
    options.UseNpgsql("Host=localhost;Port=5432;Pooling=true;Database=cadProdutos;User Id=postgres;Password=rilen6578;"));

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
