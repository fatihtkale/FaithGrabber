# FaithGrabber
ipapi.co C# Wrapper

# Usage
```cs
   public async Task<string> test()
   {
      FaithClient ipclient = new FaithClient();
      //Enter IP into the wrapper
      var req = await ipclient.Data("8.8.8.8");
      //Gets the requested IP's city (Check Data.cs for other thing you can get from the IP) 
      var res = req.city;
    
      return res;
   }
```
# Download

```
You can download the project via github or 
```

```
https://www.nuget.org/packages/FaithGrapper/1.0.0
```
