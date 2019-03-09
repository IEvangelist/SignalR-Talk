public async Task Echo(
    string message) {
    await Clients.Caller // 👈
                 .SendAsync(
                    "Echo",
                    message);
}
