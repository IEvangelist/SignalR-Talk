public void Configure(
  IApplicationBuilder app,
  IHostingEnvironment env)
{
  app.UseEndpoints(endpoints =>
  {
    // 🗺️
    endpoints.MapHub<ChatHub>("/chat");
  });
}
