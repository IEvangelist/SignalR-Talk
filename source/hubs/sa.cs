public async Task Broadcast(
    string message)
{
    await Clients.All // 👈
                 .SendAsync(
                    "Broadcast",
                    message);
}
