using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ASPWeb.Data;
using ASPWeb.Models;
//建立具有預設值的 WebApplicationBuilder，將 Razor Pages 支援新增至相依性插入 (DI) 容器，並建置應用程式
var builder = WebApplication.CreateBuilder(args); 

// Add services to the container.
builder.Services.AddRazorPages();
//建立具有預設值的 WebApplicationBuilder，將 Razor Pages 支援新增至相依性插入 (DI) 容器，並建置應用程式
builder.Services.AddDbContext<ASPWebContext>(options =>
//建立具有預設值的 WebApplicationBuilder，將 Razor Pages 支援新增至相依性插入 (DI) 容器，並建置應用程式
    options.UseSqlServer(builder.Configuration.GetConnectionString("ASPWebContext") ?? throw new InvalidOperationException("Connection string 'ASPWebContext' not found.")));

var app = builder.Build();  //到此為止

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();  //將 HTTP 要求重新導向至 HTTPS
app.UseStaticFiles();   //允許提供靜態檔案，例如 HTML、CSS、影像和 JavaScript。

app.UseRouting();   //將路由比對新增至中介軟體管線

app.UseAuthorization(); //授權給使用者存取安全資源

app.MapRazorPages();    //設定 Razor Pages 的端點路由

app.Run();
