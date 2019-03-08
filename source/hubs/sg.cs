public async Task SendGroup(
    string groupName,
    string message) {
    await Clients.Group(groupName)
                 .SendAsync(
                     "GroupMessage",
                     message);
}
