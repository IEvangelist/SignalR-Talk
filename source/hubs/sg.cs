public async Task SendToGroup(
    string groupName,
    string message) { // 👇
    await Clients.Group(groupName)
                 .SendAsync(
                    "GroupMessage",
                    message);
}
