# Angular 4 QuickStart hosted via ASP.NET Core 

This project demonstrates the simplest (?) configuration for an ASP.NET Core hosting of an Angular app.  I needed something that could take advantage of the excellent development qualities of Visual Studio (not to downplay Code, which I also love).

My requirements were:
* Simplicity of configuration - separating intracacies of SystemJS from the simplicity of Angular
* Remaining true to the _Angular Quickstart_
* Visual Studio development flow
* Refresh-on-save of both TypeScript and HTML template files using _BrowserLink_
* Hiding JS + Map files just like I can do easily in VS Code
* Easy F5 debugging (so far just IE)
* Routing support

## Special Features
The first tricky part was surfacing the `node_modules` and `src` folders _without_ putting them in `wwwroot`.  That is purely aesthetic, as I wanted to separate _source code_ from _static files_ in my mind. Plus I didn't want a gulp or npm script to copy those files on build (because I don't want to build - I just want to save and let BrowserLink resync).

The second tricky part was to make sure the contents of those files were __not__ cached.  Otherwise the browser link refresh would appear to not work.

The third tricky part involved routing.  I needed to add the appropriate entries to the  `system.webServer` element in web.config so that the index.html file would be returned when the route was unresolvable.  I do not have routing demonstrated here, but it can be added using any of the usual routing techniques, without further configuration, and it will just work.

