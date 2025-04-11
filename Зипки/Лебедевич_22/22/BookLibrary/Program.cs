// �������� � ������
using BookLibrary.Data;
using BookLibrary.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
// �������� � ������
builder.Services.AddScoped<IBookService, BookService>();
// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Logging.ClearProviders();
builder.Logging.AddConsole();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // ��� production ������ ����������� HSTS
    // app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles(); // ��������� ����������� ������ (CSS, JS � �.�.)

app.UseRouting();

app.UseAuthorization();

// ��������� ���������
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Books}/{action=Index}/{id?}");

app.Run();