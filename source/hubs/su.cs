public async Task DirectMessage(
    string userId,
    string message) { // 👇
    await Clients.User(userId)
                 .SendAsync(
                    "DirectMessage",
                    message);
}
