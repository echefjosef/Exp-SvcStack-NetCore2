# Preliminary Observations

## Build and Publish

It would appear that implementing a CLI publish using `dotnet publish` can produce a variety of options.  By default, this will create the systems best approximation of a stand-alond deployment.  Publishing can be contained and controlled by utilizing the Framework and Runtime specifiers like this:

``` powershell
dotnet publish -f netcoreapp2.0 -c Release -r win-x64
```

Where `-f` allows you to explicitly specify the target framework version, and `-r` allows you to specify the runtime target, in this case the Windows (portable) x64 runtime.  Other runtimes that may apply are the `win-x86` runtime for 32-bit operation, and the `win10-x64` and `win10-x86` runtimes for Windwos 10 and Server 2016 deployments.  There are also targets for various Linux distribusions, as well as Windows 7/8 runtimes for legacy desktop/server .net versions.


