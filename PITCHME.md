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

# SignalR@color[white](!)

@ul[no-bullets]

 - @color[gray](@fa[github-square]) &nbsp; Open-Source
 - @color[green](@fa[clock-o]) &nbsp; Real-Time Web Functionality
 - @color[teal](@fa[server]) &nbsp; Server @css[blinking](@fa[arrows-h]) Client

@ulend

---

# SignalR@color[white](?)

@ul[no-bullets]

 - @fa[check] &nbsp; Benefits - "_Are we there yet?_"
 - @fa[check] &nbsp; Use Cases - _Real-Time * 🎉_
 - @fa[check] &nbsp; Everywhere you want to be ...

@ulend

---

# Platforms

@ul[no-bullets]

 - @fa[code] &nbsp; @color[magenta](`JavaScript`) Client (IE 11)
 - @fa[smile-o] &nbsp; @color[cyan](`.NET`) Client (Android & iOS)
 - @fa[coffee] &nbsp; @color[red](`Java`) Client (Java 8 or later)
 - @fa[plus] &nbsp; @color[#004482](`C++`) Targeting 3.0 Release 
 - @fa[apple] &nbsp; @color[#FB9D3B](Swift) 3<sup>@size[1.5rem](rd)</sup> Party Implementation

@ulend

---

### @color[cyan](`Startup`)`.ConfigureServices`

@code[csharp zoom-18](source/cs.cs)

@snap[south span-100]
@[4-5](Adding the `SignalR` services into `IServiceCollection`.)
@snapend

---

### @color[cyan](`Startup`)`.Configure`

@code[csharp zoom-16](source/c.cs)

@snap[south span-100]
@[5-9](Mapping the `ChatHub` to the `"/chat"` endpoint.)
@snapend

---

### ☁️ @color[cyan](`Startup`)`.ConfigureServices`

@code[csharp zoom-18](source/acs.cs)

@snap[south span-100]
@[4-6](Adding the `SignalR` and `AzureSignalR` services into `IServiceCollection`.)
@snapend

---

### ☁️ @color[cyan](`Startup`)`.Configure`

@code[csharp zoom-16](source/ac.cs)

@snap[south span-100]
@[5-9](Mapping the `ChatHub` to the `"/chat"` endpoint.)
@snapend

---

# Transports

 - WebSockets &nbsp; @fa[globe] @fa[wrench]
 - Server-Sent Events &nbsp; @fa[server] @fa[arrow-right] @fa[bolt]
 - Long Polling &nbsp; @fa[long-arrow-right] @fa[list-alt]

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

# Recap

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
<blockquote>The SignalR Hub<br/>is the proxy between<br/>Server and Client(s)</blockquote>
@snapend

---

# @color[magenta](@fa[magic]) Strings

> We could extend the @color[cyan](`Hub<T>`) instead of the @color[cyan](`Hub`), this gives us a 💪-typed alternative.

---

### @color[cyan](`ChatHub`)`.Broadcast`

@code[csharp zoom-18](source/hubs/sa.cs)

@snap[south span-100]
@[4-7](Everyone connected to this `Hub` receives the message)
@snapend

---

<div class="grid-container">

  <i class="fa fa-2x fa-arrows-h tla" aria-hidden="true"></i>
  <i class="fa fa-2x fa-long-arrow-left tca" aria-hidden="true"></i>
  <i class="fa fa-2x fa-long-arrow-left tra" aria-hidden="true"></i>
  <i class="fa fa-2x fa-long-arrow-left mla" aria-hidden="true"></i>
  <i class="fa fa-2x fa-long-arrow-right mra" aria-hidden="true"></i>
  <i class="fa fa-2x fa-long-arrow-left bla" aria-hidden="true"></i>
  <i class="fa fa-2x fa-long-arrow-left bca" aria-hidden="true"></i>
  <i class="fa fa-2x fa-long-arrow-left bra" aria-hidden="true"></i>

  <div class="top-left sender">
    Dave (Sender)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
  <div class="top-center">
    Maggie (UX)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
  <div class="top-right">
    Carol (Dev)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
  <div class="middle-left">
    Rachel (UX)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
  <div class="middle-center">
    @css[signalr](__Chat Hub__)
    <br/>
    <i class="fa fa-4x fa-server signalr" aria-hidden="true"></i>
  </div>
  <div class="middle-right">
    Maria (Dev)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
  <div class="bottom-right">
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
    <br/>Max (DevOps)
  </div>
  <div class="bottom-left">
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
    <br/>... (Bot)
  </div>
  <div class="bottom-center">
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
    <br/>Steve (Dev)
  </div>
</div>

---

### @color[cyan](`ChatHub`)`.Echo`

@code[csharp zoom-18](source/hubs/sc.cs)

@snap[south span-100]
@[4-7](Only I get this message, it's an `"echo"`)
@snapend

---

<div class="grid-container">

  <i class="fa fa-2x fa-arrows-h tla" aria-hidden="true"></i>

  <div class="top-left sender">
    Dave (Sender)
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
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
    <br/>Max (DevOps)
  </div>
  <div class="bottom-left dimmed">
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
    <br/>... (Bot)
  </div>
  <div class="bottom-center dimmed">
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
    <br/>Steve (Dev)
  </div>
</div>

---

### @color[cyan](`ChatHub`)`.SendToOthers`

@code[csharp zoom-18](source/hubs/so.cs)

@snap[south span-100]
@[3-6](Everyone connected to this `Hub` receives the message, except for me)
@snapend

---

<div class="grid-container">

  <i class="fa fa-2x fa-long-arrow-right tla" aria-hidden="true"></i>
  <i class="fa fa-2x fa-long-arrow-left tca" aria-hidden="true"></i>
  <i class="fa fa-2x fa-long-arrow-left tra" aria-hidden="true"></i>
  <i class="fa fa-2x fa-long-arrow-left mla" aria-hidden="true"></i>
  <i class="fa fa-2x fa-long-arrow-right mra" aria-hidden="true"></i>
  <i class="fa fa-2x fa-long-arrow-left bla" aria-hidden="true"></i>
  <i class="fa fa-2x fa-long-arrow-left bca" aria-hidden="true"></i>
  <i class="fa fa-2x fa-long-arrow-left bra" aria-hidden="true"></i>

  <div class="top-left sender">
    Dave (Sender)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
  <div class="top-center">
    Maggie (UX)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
  <div class="top-right">
    Carol (Dev)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
  <div class="middle-left">
    Rachel (UX)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
  <div class="middle-center">
    @css[signalr](__Chat Hub__)
    <br/>
    <i class="fa fa-4x fa-server signalr" aria-hidden="true"></i>
  </div>
  <div class="middle-right">
    Maria (Dev)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
  <div class="bottom-right">
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
    <br/>Max (DevOps)
  </div>
  <div class="bottom-left">
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
    <br/>... (Bot)
  </div>
  <div class="bottom-center">
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
    <br/>Steve (Dev)
  </div>
</div>

---

### @color[cyan](`ChatHub`)`.SendToGroup`

@code[csharp zoom-18](source/hubs/sg.cs)

@snap[south span-100]
@[4-7](Everyone connected to this `Hub` and in this group receives the message)
@snapend

---

<div class="grid-container">

  <i class="fa fa-2x fa-long-arrow-right tla" aria-hidden="true"></i>
  <i class="fa fa-2x fa-long-arrow-left tca" aria-hidden="true"></i>
  <i class="fa fa-2x fa-long-arrow-left mla" aria-hidden="true"></i>

  <div class="top-left sender">
    Dave (Sender)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
  <div class="top-center">
    Maggie (UX)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
  <div class="top-right dimmed">
    Carol (Dev)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
  <div class="middle-left">
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
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
    <br/>Max (DevOps)
  </div>
  <div class="bottom-left dimmed">
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
    <br/>... (Bot)
  </div>
  <div class="bottom-center dimmed">
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
    <br/>Steve (Dev)
  </div>
</div>

---

### @color[cyan](`ChatHub`)`.DirectMessage`

@code[csharp zoom-18](source/hubs/su.cs)

@snap[south span-100]
@[4-7](This is a direct message to a specific user)
@snapend

---

<div class="grid-container">

  <i class="fa fa-2x fa-long-arrow-right tla" aria-hidden="true"></i>
  <i class="fa fa-2x fa-long-arrow-right mra" aria-hidden="true"></i>

  <div class="top-left sender">
    Dave (Sender)
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
  <div class="middle-right">
    Maria (Dev)
    <br/>
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
  </div>
  <div class="bottom-right dimmed">
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
    <br/>Max (DevOps)
  </div>
  <div class="bottom-left dimmed">
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
    <br/>... (Bot)
  </div>
  <div class="bottom-center dimmed">
    <i class="fa fa-4x fa-user" aria-hidden="true"></i>
    <br/>Steve (Dev)
  </div>
</div>

---

# Protocols

@ul[no-bullets](false)
 - @fa[file-text-o] &nbsp; [JSON (Text-Based) @fa[external-link]](https://www.newtonsoft.com/json)
 - @fa[file-archive-o] &nbsp; [MessagePack (Binary) @fa[external-link]](https://msgpack.org/index.html)
@ulend

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

# Recap

@ul[no-bullets](false)
 - @fa[check] &nbsp; ASP.NET Core + @color[magenta](Blazor)
 - @fa[check] &nbsp; @color[grey](`MessagePack`) Protocol
 - @fa[check] &nbsp; @css[twitter](Twitter) Streaming
 - @fa[check] &nbsp; [bit.ly/signalr-blazing @fa[external-link]](http://bit.ly/signalr-blazing)
@ulend

---

# 😲 Perf

@ul[no-bullets](false)
 - @color[gray](@fa[fighter-jet]) &nbsp; [ASP.NET Core BenchMarks @fa[external-link]](https://aka.ms/aspnet/BenchMarks)
 - @color[yellow](@fa[bolt]) &nbsp; &nbsp; [SignalR Benchmarks @fa[external-link]](https://msit.powerbi.com/view?r=eyJrIjoiYTZjMTk3YjEtMzQ3Yi00NTI5LTg5ZDItNmUyMGRlOTkwMGRlIiwidCI6IjcyZjk4OGJmLTg2ZjEtNDFhZi05MWFiLTJkN2NkMDExZGI0NyIsImMiOjV9&pageName=ReportSectionffcb2816a4d9d4f28542)
@ulend

---

# 📖 Specs

[ASP.NET Core SignalR - Specs @fa[external-link]](https://github.com/aspnet/AspNetCore/tree/master/src/SignalR/docs/specs)

> The @css[signalr](SignalR) Protocol is a protocol for two-way RPC over any Message-based transport.

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

# Recap

@ul[no-bullets](false)
 - @fa[check] &nbsp; ASP.NET Core + @color[#F44336](Angular)
 - @fa[check] &nbsp; @color[grey](`JSON`) Protocol
 - @fa[check] &nbsp; Video ASCII Art (pseudo-stream)
 - @fa[check] &nbsp; [bit.ly/signalr-streaming @fa[external-link]](http://bit.ly/signalr-streaming)
@ulend

---

# Resources

@ul[no-bullets](false)
 - @fa[link] &nbsp; [bit.ly/signalr-chat](https://bit.ly/signalr-chat)
 - @fa[link] &nbsp; [bit.ly/signalr-blazing](http://bit.ly/signalr-blazing)
 - @fa[link] &nbsp; [bit.ly/signalr-streaming](http://bit.ly/signalr-streaming)
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