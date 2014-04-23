# HipChat.NET #

HipChat API v2 client library for .NET

## Supported Platforms

* .NET 4.5+ (Desktop / Server)
* Windows 8.1 Universal apps (Desktop / Phone / Tablet)

## Nuget ##

`PM> install-package HipChat.Net.Portable`

## Examples ##

```c#
// get hipchat client instance
var hipChat = new HipChatClient(new ApiConnection(new Credentials("OAuthToken")));
// get all rooms
var rooms = await hipChat.Rooms.GetAllAsync();
// get room members
var members = await hipChat.Rooms.GetMembersAsync("roomNameOrId")
// get recent room message history
await hipChat.Rooms.GetHistoryAsync("roomNameOrId")
```

For more examples, see the [HipChatWeb](src/HipChatWeb) project in the repository.

## Build ##
Using msbuild (v12+) against [HipChat.Net.csproj](src/HipChat.Net/HipChat.Net.csproj).


## Requirements ##
- Visual Studio 2012/2013
- Windows 8.1 for WinRT/Universal projects.

## Copyright & License ##

Copyright 2014 Chris Kirby
[MIT License](LICENSE.txt)

