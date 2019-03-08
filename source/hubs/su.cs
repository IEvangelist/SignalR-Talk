public async Task SendUser(
    string userId,
    string message) {
    await Clients.User(userId)
                 .SendAsync(
                     "DM",
                     message);
}
