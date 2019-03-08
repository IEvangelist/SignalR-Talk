public async Task SendOthers(
    string message) {
    await Clients.Others
                 .SendAsync(
                    "SendOthers",
                    message);
}
