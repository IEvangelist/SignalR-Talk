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

 - @color[gray](@fa[github-square]) &nbsp; Open-Source
 - @color[green](@fa[clock-o]) &nbsp; Real-Time Web Functionality
 - @color[teal](@fa[server]) &nbsp; Server pushes content to client

@ulend

---

# Platforms

@ul[no-bullets]

 - @fa[code] &nbsp; @color[magenta](`JavaScript`) Client (IE 11)
 - @fa[smile-o] &nbsp; @color[cyan](`.NET`) Client (Android & iOS)
 - @fa[exclamation-circle] &nbsp; @color[red](`Java`) Client (Java 8 or later)

@ulend

---

### @color[cyan](`Startup`)`.ConfigureServices`

@code[csharp zoom-18](source/cs.cs)

@snap[south span-100]
@[4-5](Adding the `SignalR` services into `IServiceCollection`.)
@snapend

---

### @color[cyan](`Startup`)`.Configure`

@code[csharp zoom-18](source/c.cs)

@snap[south span-100]
@[5-9](Mapping the `ChatHub` to the `"/chat"` endpoint.)
@snapend

---

# Transports

 - WebSockets
 - Server-Sent Events
 - Long Polling

> The best transport is automatically chosen based on server and client capabilities.

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
 - @fa[check] &nbsp; Razor Pages + @color[#41B883](`VueJS`)
 - @fa[check] &nbsp; @color[grey](`JSON`) Protocol
 - @fa[check] &nbsp; Azure SignalR
 - @fa[check] &nbsp; [bit.ly/signalr-chat @fa[external-link]](https://bit.ly/signalr-chat)
@ulend

---?image=assets/hubs.jpg&size=contain

@snap[north-east]
# @color[--signalr](@css[stark-shadow](Hubs))
@snapend

@snap[south-east dark-bg]
<blockquote>The SignalR Hub<br/>is the proxy between<br/>Server and Client</blockquote>
@snapend

---

### @color[cyan](`ChatHub`)`.SendAll`

@code[csharp zoom-18](source/hubs/sa.cs)

@snap[south span-100]
@[3-6](Everyone connected to this hubs receives the message)
@snapend

---

<div class="grid-container">
  <div class="top-left blinking">
    Dave (Dev)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
  <div class="top-center blinking">
    Maggie (UX)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
  <div class="top-right blinking">
    Carol (Dev)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
  <div class="middle-left blinking">
    Rachel (UX)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
  <div class="middle-center offset-blinking">
    @css[signalr](__Chat Hub__)
    <br/>
    <i class="fa fa-4x fa-server signalr" aria-hidden="true"></i>
  </div>
  <div class="middle-right blinking">
    Maria (Dev)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
  <div class="bottom-right blinking">
    Max (DevOps)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
  <div class="bottom-left blinking">
    ... (Bot)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
  <div class="bottom-center blinking">
    Steve (Dev)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
</div>

---

### @color[cyan](`ChatHub`)`.SendCaller`

@code[csharp zoom-18](source/hubs/sc.cs)

@snap[south span-100]
@[3-6](Only I get this message, it's an "echo")
@snapend

---

<div class="grid-container">
  <div class="top-left blinking">
    Dave (Dev)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
  <div class="top-center dimmed">
    Maggie (UX)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
  <div class="top-right dimmed">
    Carol (Dev)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
  <div class="middle-left dimmed">
    Rachel (UX)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
  <div class="middle-center">
    @css[signalr](__Chat Hub__)
    <br/>
    <i class="fa fa-4x fa-server signalr" aria-hidden="true"></i>
  </div>
  <div class="middle-right dimmed">
    Maria (Dev)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
  <div class="bottom-right dimmed">
    Max (DevOps)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
  <div class="bottom-left dimmed">
    ... (Bot)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
  <div class="bottom-center dimmed">
    Steve (Dev)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
</div>

---

### @color[cyan](`ChatHub`)`.SendOthers`

@code[csharp zoom-18](source/hubs/so.cs)

@snap[south span-100]
@[3-6](Everyone connected to this hubs receives the message, except for me)
@snapend

---

<div class="grid-container">
  <div class="top-left dimmed">
    Dave (Dev)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
  <div class="top-center blinking">
    Maggie (UX)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
  <div class="top-right blinking">
    Carol (Dev)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
  <div class="middle-left blinking">
    Rachel (UX)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
  <div class="middle-center">
    @css[signalr](__Chat Hub__)
    <br/>
    <i class="fa fa-4x fa-server signalr" aria-hidden="true"></i>
  </div>
  <div class="middle-right blinking">
    Maria (Dev)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
  <div class="bottom-right blinking">
    Max (DevOps)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
  <div class="bottom-left blinking">
    ... (Bot)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
  <div class="bottom-center blinking">
    Steve (Dev)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
</div>

---

### @color[cyan](`ChatHub`)`.SendGroup`

@code[csharp zoom-18](source/hubs/sg.cs)

@snap[south span-100]
@[4-7](Everyone connected to this hub and in this group receives the message)
@snapend

---

<div class="grid-container">
  <div class="top-left dimmed">
    Dave (Dev)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
  <div class="top-center blinking">
    Maggie (UX)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
  <div class="top-right dimmed">
    Carol (Dev)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
  <div class="middle-left blinking">
    Rachel (UX)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
  <div class="middle-center">
    @css[signalr](__Chat Hub__)
    <br/>
    <i class="fa fa-4x fa-server signalr" aria-hidden="true"></i>
  </div>
  <div class="middle-right dimmed">
    Maria (Dev)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
  <div class="bottom-right dimmed">
    Max (DevOps)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
  <div class="bottom-left dimmed">
    ... (Bot)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
  <div class="bottom-center dimmed">
    Steve (Dev)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
</div>

---

### @color[cyan](`ChatHub`)`.SendUser`

@code[csharp zoom-18](source/hubs/su.cs)

@snap[south span-100]
@[4-7](This is a direct message to a specific user)
@snapend

---

<div class="grid-container">
  <div class="top-left dimmed">
    Dave (Dev)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
  <div class="top-center dimmed">
    Maggie (UX)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
  <div class="top-right dimmed">
    Carol (Dev)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
  <div class="middle-left dimmed">
    Rachel (UX)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
  <div class="middle-center">
    @css[signalr](__Chat Hub__)
    <br/>
    <i class="fa fa-4x fa-server signalr" aria-hidden="true"></i>
  </div>
  <div class="middle-right blinking">
    Maria (Dev)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
  <div class="bottom-right dimmed">
    Max (DevOps)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
  <div class="bottom-left dimmed">
    ... (Bot)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
  <div class="bottom-center dimmed">
    Steve (Dev)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
</div>

---

# Protocols

 - [JSON (Text-Based) @fa[external-link]](https://www.newtonsoft.com/json)
 - [MessagePack (Binary) @fa[external-link]](https://msgpack.org/index.html)

> The SignalR Protocol is a protocol for two-way RPC over any Message-based transport

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
 - @fa[check] &nbsp; ASP.NET Core + @color[magenta](Blazor)
 - @fa[check] &nbsp; @color[grey](`MessagePack`) Protocol
 - @fa[check] &nbsp; @css[twitter](Twitter) Streaming
 - @fa[check] &nbsp; [bit.ly/signalr-blazing @fa[external-link]](http://bit.ly/signalr-blazing)
@ulend

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
 - @fa[check] &nbsp; ASP.NET Core + @color[#F44336](Angular)
 - @fa[check] &nbsp; @color[grey](`JSON`) Protocol
 - @fa[check] &nbsp; Video ASCII Art (pseudo-stream)
 - @fa[check] &nbsp; [bit.ly/signalr-streaming @fa[external-link]](http://bit.ly/signalr-streaming)
@ulend

---

# Resources

 - [bit.ly/signalr-chat @fa[external-link]](https://bit.ly/signalr-chat)
 - [bit.ly/signalr-blazing @fa[external-link]](http://bit.ly/signalr-blazing)
 - [bit.ly/signalr-streaming @fa[external-link]](http://bit.ly/signalr-streaming)

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