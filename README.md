# Angular 4 QuickStart hosted via ASP.NET Core 

This project demonstrates the simplest (?) configuration for an ASP.NET Core hosting of an Angular app.  I needed something that could take advantage of the excellent development qualities of Visual Studio (not to downplay Code, which I also love).

My requirements were:
* Simplicity of configuration
* Remaining true to the _Angular Quickstart_
* Visual Studio development flow
* Refresh-on-save of both TypeScript and HTML template files
* BrowserLink Support
* Hiding JS + Map files just like I can do easily in VS Code
* Easy F5 debugging

## Special Features
The only tricky part was surfacing the `node_modules` and `src` folders _without_ putting them in `wwwroot`.  That is purely aesthetic, as I wanted to separate _source code_ from _static files_ in my mind. Plus I didn't want a gulp or npm script to copy those files on build (because I don't want to build - I just want to save and let BrowserLink resync).

