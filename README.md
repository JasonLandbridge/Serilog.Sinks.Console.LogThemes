# Serilog.Sinks.Console.LogThemes

An extension for the great [Serilog Sinks Console](https://github.com/serilog/serilog-sinks-console) which provides the following extra features:

- More themes, including the ones from the [Serilog Sinks Console](https://github.com/serilog/serilog-sinks-console#themes) which are a 1 to 1 replica, but written in Fluent styling!
- Complete fluent styling of themes with 16-color, 256-color and [Truecolor](https://en.wikipedia.org/wiki/Color_depth#True_color_.2824-bit.29) (24-bit RGB) support!
- All themes are fully extendable and can be overwritten on a per property base!
- Easy demo functionality to quickly test how every theme looks in your IDE!
- This project only has one dependency and is fully compatible with [Serilog Sinks Console](https://github.com/serilog/serilog-sinks-console)!

# Getting started

To use `Serilog.Sinks.Console.LogThemes`:
```
dotnet add package Serilog.Sinks.Console.LogThemes
```

Note: `Serilog.Sinks.Console.LogThemes` already has a dependency on `Serilog.Sinks.Console.LogThemes`, so it's not necessary to install both.

Then enable the sink using `WriteTo.Console()` and select a theme from `LogThemes`:

```csharp

Log.Logger = new LoggerConfiguration()
.WriteTo.Console(theme: LogThemes.Sixteen) // <= Select theme here
.CreateLogger();

Log.Information("Hello, world!");
```


# Themes

The following built-in themes are available:

Note: All images are screenshots from Jetbrains Rider with Rider Light theme and Visual Studio Dark Plus theme for the dark-mode

<details>
  <summary><b>Show all theme previews!</b></summary>


###  * `LogThemes.None` - no styling

### - `LogThemes.Literate` - styled to replicate
_Serilog.Sinks.Literate_, using the `System.Console` coloring modes supported on all Windows/.NET targets; **this is the default when no theme is
specified**

### - `LogThemes.SystemGrayscale` - a theme using only shades of gray, white, and black

Light-mode:
![System Grayscale Light Mode Screenshot](./Assets/Screenshots/SystemGrayscale-light-mode.png "System Grayscale Light Mode Screenshot")

Dark-mode:
![System Grayscale Dark Mode Screenshot](./Assets/Screenshots/SystemGrayscale-dark-mode.png "System Grayscale Dark Mode Screenshot")

### - `LogThemes.Literate` - an ANSI 256-color version of the "literate" theme

### - `LogThemes.Grayscale` - an ANSI 256-color version of the "grayscale" theme

### - `LogThemes.Code` - an ANSI 256-color Visual Studio Code-inspired theme

### - `LogThemes.Sixteen` - an ANSI 16-color theme that works well with both light and dark backgrounds

</details>

# Fluent styling

# Custom Templating

# Log demo

# Resources

https://gist.github.com/fnky/458719343aabd01cfb17a3a4f7296797#colors--graphics-mode

# Contributions