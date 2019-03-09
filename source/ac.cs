public void Configure(
    IApplicationBuilder app,
    IHostingEnvironment env)
{
    app.UseAzureSignalR(routes =>
    {
        // 🗺️
        routes.MapHub<ChatHub>("/chat");
    });
}
