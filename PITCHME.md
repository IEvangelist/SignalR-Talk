---
@size[3em](@css[signalr](SignalR))
## Above & Beyond Chat
---

<img class="me" src="assets/me.png" height="600" />

@snap[south-west]
[@css[twitter](@fa[twitter]) @davidpine7](https://twitter.com/davidpine7)
@snapend

@snap[north-west img-fit]
![Most Valuable Professional](assets/mvp.png)
@snapend

@snap[south-east]
[davidpine.net @color[red](@fa[globe])](http://davidpine.net/)
@snapend

@snap[north-east img-fit]
![Google Developer Expert](assets/gde.png)
@snapend

---

# SignalR

@ul[no-bullets]

 - @fa[github]    Open-source
 - @fa[clock-o]   Real-time web functionality
 - @fa[server]   Server pushes content to Client 

@ulend

---

# NuGet

[Microsoft.AspNetCore.SignalR](https://www.nuget.org/packages/Microsoft.AspNetCore.SignalR/)

[Microsoft.AspNetCore.SignalR.Client](https://www.nuget.org/packages/Microsoft.AspNetCore.SignalR.Client/)

[Microsoft.AspNetCore.SignalR.Protocols.MessagePack](https://www.nuget.org/packages/Microsoft.AspNetCore.SignalR.Protocols.MessagePack/)

---

# NPM

[@aspnet/signalr](https://www.npmjs.com/package/@aspnet/signalr)

[@aspnet/signalr-protocol-msgpack](https://www.npmjs.com/package/@aspnet/signalr-protocol-msgpack)

---

---?color=#333

@code[csharp zoom-19](source/Startup.cs)

@snap[south span-100]
@[20](Adding the `SignalR` services into `IServiceCollection.`)
@[38-40](Use `SignalR` and map a route given my `Hub` subclass and its corresponding route.)
@snapend

---

# Transports

 - WebSockets
 - Server-Sent Events
 - Long Polling

> The best transport is automatically chosen based on server and client capabilities.

---?image=assets/hubs.jpg&size=contain

@snap[north-east]
# @color[#222](Hubs)
@snapend

---

# Protocols

 - JSON (Text-Based)
 - MessagePack (Binary)

---

@snap[east]
# @color[white](Demo)
@snapend
<div class="logo">
    <svg viewBox="0 0 275 275" class="signalr-svg"  xmlns="http://www.w3.org/2000/svg">
        <path d="M135 0a135 135 0 1 0 42.59 263.14l-67-67 13.79-38.59h36.5a22.56 22.56 0 0 0 0-45.12H52.11v-1l55.76-55.75h1V74h52a60.89 60.89 0 0 1 2.93 121.7l49.36 49.37A135 135 0 0 0 135 0z" />
    </svg>
</div>

---

# Summary

 + Chat App (Much Improved)
 + Razor Pages + VueJS
 + JSON Protocol
 + Azure SignalR

 <a href='https://bit.ly/signalr-chat' target='_blank'>bit.ly/signalr-chat</a>

---

# Perf

<a href='aka.ms/aspnet/BenchMarks' target='_blank'>
aka.ms/aspnet/BenchMarks
</a>

---

# Specs

<a href='https://github.com/aspnet/AspNetCore/tree/master/src/SignalR/docs/specs' target=''>
ASP.NET Core SignalR - Specs
</a>

---

@snap[east]
# @color[white](Demo)
@snapend
<div class="logo">
    <svg viewBox="0 0 275 275" class="signalr-svg"  xmlns="http://www.w3.org/2000/svg">
        <path d="M135 0a135 135 0 1 0 42.59 263.14l-67-67 13.79-38.59h36.5a22.56 22.56 0 0 0 0-45.12H52.11v-1l55.76-55.75h1V74h52a60.89 60.89 0 0 1 2.93 121.7l49.36 49.37A135 135 0 0 0 135 0z" />
    </svg>
</div>

---

# Summary

---

@snap[east]
# @color[white](Demo)
@snapend
<div class="logo">
    <svg viewBox="0 0 275 275" class="signalr-svg"  xmlns="http://www.w3.org/2000/svg">
        <path d="M135 0a135 135 0 1 0 42.59 263.14l-67-67 13.79-38.59h36.5a22.56 22.56 0 0 0 0-45.12H52.11v-1l55.76-55.75h1V74h52a60.89 60.89 0 0 1 2.93 121.7l49.36 49.37A135 135 0 0 0 135 0z" />
    </svg>
</div>

---

# Thank you
<img class="me" src="assets/me.png" height="450" />
<br/>
@snap[west]
[@css[twitter](@fa[twitter]) @davidpine7](https://twitter.com/davidpine7)
@snapend

@snap[east]
[davidpine.net @color[red](@fa[globe])](http://davidpine.net/)
@snapend