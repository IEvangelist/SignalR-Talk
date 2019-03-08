public async Task SendCaller(
    string message) {
    await Clients.Caller
                 .SendAsync(
                     "Echo",
                     message);
}
