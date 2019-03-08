---
# @color[--signalr](SignalR)
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

# @color[white](I) @color[red](@fa[heart]) @color[white](The)
### #DeveloperCommunity @css[twitter](@fa[twitter])

---

# SignalR@color[white](?)

@ul[no-bullets]

 - @fa[github] &nbsp; Open-Source
 - @fa[clock-o] &nbsp; Real-Time Web Functionality
 - @fa[server] &nbsp; Server pushes content to client

@ulend

---

# Platforms

@ul[no-bullets]

 - @fa[code] &nbsp; @color[magenta](`JavaScript`) Client (IE 11)
 - @fa[smile-o] &nbsp; @color[cyan](`.NET`) Client (Android & iOS)
 - @fa[exclamation-circle] &nbsp; @color[red](`Java`) Client (Java 8 or later)

@ulend

---?color=#333

### @color[cyan](`Startup`)`.ConfigureServices`

@code[csharp zoom-18](source/cs.cs)

@snap[south span-100]
@[3-5](Adding the `SignalR` services into `IServiceCollection`.)
@snapend

---?color=#333

### @color[cyan](`Startup`)`.Configure`

@code[csharp zoom-18](source/c.cs)

@snap[south span-100]
@[4-8](Mapping the `ChatHub` to the `"/chat"` endpoint.)
@snapend

---

# Transports

 - WebSockets
 - Server-Sent Events
 - Long Polling

> The best transport is automatically chosen based on server and client capabilities.

---?image=assets/hubs.jpg&size=contain

@snap[north-east]
# @color[--signalr](@css[stark-shadow](Hubs))
@snapend

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

@ul[no-bullets](false)
 - @fa[check] &nbsp; Razor Pages + `VueJS`
 - @fa[check] &nbsp; `JSON` Protocol
 - @fa[check] &nbsp; __Azure__ SignalR
 - @fa[check] &nbsp; [bit.ly/signalr-chat @fa[external-link]](https://bit.ly/signalr-chat)
@ulend

---

# Protocols

 - [JSON (Text-Based) @fa[external-link]](https://www.newtonsoft.com/json)
 - [MessagePack (Binary) @fa[external-link]](https://msgpack.org/index.html)

> The SignalR Protocol is a protocol for two-way RPC over any Message-based transport

---

# @fa[fighter-jet] Perf

[aka.ms/aspnet/BenchMarks @fa[external-link]](https://aka.ms/aspnet/BenchMarks)

---

# @fa[file-text] Specs

[ASP.NET Core SignalR - Specs @fa[external-link]](https://github.com/aspnet/AspNetCore/tree/master/src/SignalR/docs/specs)

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

@ul[no-bullets](false)
 - @fa[check] &nbsp; Blazor
 - @fa[check] &nbsp; `MessagePack` Protocol
 - @fa[check] &nbsp; Twitter Streaming
@ulend

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

@ul[no-bullets](false)
 - @fa[check] &nbsp; ASP.NET Core + Angular
 - @fa[check] &nbsp; `JSON` Protocol
 - @fa[check] &nbsp; Video ASCII Art (pseudo-stream)
@ulend

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