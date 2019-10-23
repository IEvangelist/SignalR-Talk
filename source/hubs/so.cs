public async Task SendToOthers(
  string message)
{
  await Clients.Others // 👈
               .SendAsync(
                  "SendToOthers",
                  message);
}
