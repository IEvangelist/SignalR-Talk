public async Task SendAll(
    string message)
{
    await Clients.All
                 .SendAsync(
                    "Message",
                    message);
}
