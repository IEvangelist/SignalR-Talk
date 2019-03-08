public void Configure(
  IApplicationBuilder app,
  IHostingEnvironment env)
{
  app.UseSignalR(routes =>
  {
    routes.MapHub<ChatHub>("/chat");
  });
}