var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // Для production обычно добавляется HSTS
    // app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles(); // Включение статических файлов (CSS, JS и т.д.)

app.UseRouting();

app.UseAuthorization();

// Настройка маршрутов
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Books}/{action=Index}/{id?}");

app.Run();