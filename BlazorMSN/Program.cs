using BlazorMSN.Core.Domain.RepositoryContracts;
using BlazorMSN.Core.ServiceContracts;
using BlazorMSN.Core.Services;
using BlazorMSN.Data;
using BlazorMSN.Infrastructure.DbContext;
using BlazorMSN.Infrastructure.Repositories;
using BlazorMSN.UI.Hubs;
using Microsoft.AspNetCore.ResponseCompression;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddScoped<IUserAdderService, UserAdderService>();
builder.Services.AddScoped<IUserGetterService, UserGetterService>();
builder.Services.AddScoped<IUserDeleterService, UserDeleterService>();
builder.Services.AddScoped<IUsersRepository, UsersRepository>();
builder.Services.AddSingleton<FakeApplicationDbContext>();
// Fake Database context for simplicity

// ============================================================
// Response compression between server and client to speed up
// ============================================================
builder.Services.AddResponseCompression(options =>
{
	// MIME types for data type sent with the paylod of request
	options.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(new[] { "application/octate-stream" });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}
else
{
	app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();

// ===========================================
// Map Blazor endpoint for the ChatHub
// ===========================================
app.UseEndpoints(endpoints =>
{
	endpoints.MapHub<ChatHub>("/chathub");
});

app.MapFallbackToPage("/_Host");

app.Run();
