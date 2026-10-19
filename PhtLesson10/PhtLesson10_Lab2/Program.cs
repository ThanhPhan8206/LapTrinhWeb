var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

// 1. Cấu hình Route: Admin/Student/List trỏ về StudentController -> Action Index
app.MapControllerRoute(
    name: "StudentList",
    pattern: "Admin/Student/List",
    defaults: new { controller = "Student", action = "Index" });

// 2. Cấu hình Route: Admin/Student/Add trỏ về StudentController -> Action Create
app.MapControllerRoute(
    name: "StudentAdd",
    pattern: "Admin/Student/Add",
    defaults: new { controller = "Student", action = "Create" });

// 3. Route mặc định có sẵn của project (nằm dưới cùng)
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Student}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();