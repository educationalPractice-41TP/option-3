// �������� � ������
using BookLibrary.Services;

var builder = WebApplication.CreateBuilder(args);

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