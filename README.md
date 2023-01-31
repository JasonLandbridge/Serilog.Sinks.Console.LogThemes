# Serilog.Sinks.Console.LogThemes

An extension for the great [Serilog Sinks Console](https://github.com/serilog/serilog-sinks-console) which provides the following extra features:

- More themes, including the ones from the [Serilog Sinks Console](https://github.com/serilog/serilog-sinks-console#themes) which are a 1 to 1 replica, but written in Fluent styling!
- Complete fluent styling of themes with 16-color, 256-color and [Truecolor](https://en.wikipedia.org/wiki/Color_depth#True_color_.2824-bit.29) (24-bit RGB) support!
- All themes are fully extendable and can be overwritten on a per property base!
- Easy demo functionality to quickly test how every theme looks in your IDE!
- This project only has one dependency and is fully compatible with [Serilog Sinks Console](https://github.com/serilog/serilog-sinks-console)!

Make sure to star this project as a thank you, it makes me feel good about myself :P

## What you should know

There are two types of themes:

- `SystemConsoleThemes` - These are basically legacy themes with better overall terminal support, these however only support a Foreground and Background color in 16 colors
- `AnsiThemes` - These are modern themes that support everything between 16 colors, 256 colors and Truecolor (24-bit RGB) with additional log formatting, think Bold, Italic, Underline etc

How a specific theme looks in your terminal of your IDE of choice, can vary wildly so to get a quick demo how each theme looks in your IDE, take a look at [LogTheme demo](https://github.com/JasonLandbridge/Serilog.Sinks.Console.LogThemes#demo)

## Getting started

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

## Themes

Note: I initially planned on making screenshots for everything but how you will see every theme in your specific IDE and terminal, with your specific settings, will be completely different from the screenshots anyway. 

The following built-in themes are available through the `LogThemes` class:

Ansi Themes
- `LogThemes.Empty` - no styling, just plain white/black logging
- `LogThemes.Code` - an ANSI 256-color Visual Studio Code-inspired theme
- `LogThemes.Grayscale` - an ANSI 256-color version of the "grayscale" theme
- `LogThemes.Literate` - an ANSI 256-color version of the "literate" theme
- `LogThemes.Sixteen` - an ANSI 16-color theme that works well with both light and dark backgrounds
- `LogThemes.SixteenNonBright` - Extended from `LogThemes.Sixteen` with the log level background colors muted.

System Console Themes

- `LogThemes.SystemColored` - Basic grayscale logging except for the background of the log levels
- `LogThemes.SystemGrayscale` - a theme using only shades of gray, white, and black
- `LogThemes.SystemLiterate` - styled to replicate _Serilog.Sinks.Literate_, using the `System.Console` coloring modes supported on all Windows/.NET targets;
  - **this is the default when no theme is specified**

## Demo

Wondering how each theme looks in your IDE?

Well wonder no further because you have the following options to quickly check how everything looks:

Note: the following can be placed anywhere but ideally in you Program.cs Main function and should NEVER be pushed to production.

### Test a single theme:
```csharp
// Predefined theme test
await LogThemeDemo.TestTheme(LogThemes.Sixteen);

// Custom theme test
var theme = LogThemes.UseAnsiTheme<CustomCodeThemeTemplate>();
await LogThemeDemo.TestTheme(theme);
```

### Test all predefined themes:
```csharp
// This will print out every theme with the corresponding Theme name 
// so you can pick and choose what you like
await LogThemeDemo.TestAllThemes();
```

### Test various random colors and theme settings

```csharp
await LogThemeDemo.TasteTheRainbow(config =>
{
    // Optional config
    config.Loops = 30;
    config.RandomForeground = true;
    config.RandomBackground = false;
    config.RandomFormatType = true;
    config.UseColor256 = false;
    config.DelayBetweenLogs = 50;
});
```

## Custom Theme

All themes can be extended and overwritten on a per property basis, or essentially be created from scratch by extending either the BaseSystemConsoleTheme or BaseAnsiTheme  

1. Extend either the [BaseSystemConsoleTheme](https://github.com/JasonLandbridge/Serilog.Sinks.Console.LogThemes/blob/master/src/Serilog.Sinks.Console.LogThemes/Themes/BaseThemeTemplates/BaseSystemConsoleTheme.cs) or [BaseAnsiTheme](https://github.com/JasonLandbridge/Serilog.Sinks.Console.LogThemes/blob/master/src/Serilog.Sinks.Console.LogThemes/Themes/BaseThemeTemplates/BaseAnsiTheme.cs), or any other predefined [themes](https://github.com/JasonLandbridge/Serilog.Sinks.Console.LogThemes/tree/master/src/Serilog.Sinks.Console.LogThemes/Themes)
2. Override the properties that you want changed
3. Set the theme in the logger config:
```csharp
Log.Logger = new LoggerConfiguration()
    .WriteTo.Console(theme: LogThemes.UseAnsiTheme<CustomCodeThemeTemplate>()) // <= Select ANSI theme here
    .WriteTo.Console(theme: LogThemes.UseSystemConsoleTheme<CustomCodeThemeTemplate>()) // <= Or select System Console theme here
    .CreateLogger();
```

## Fluent styling

Inside every theme you have a powerful `LogTheme` (ANSI) and `LogSystemTheme` (System Console) class that can setup a style to however you would like it!

```csharp
public class CustomCodeThemeTemplate : CodeAnsiThemeTemplate
{
    // Use the LogTheme class to set the Foreground(), Background() and or FormatType()
    protected override string Text { get; } = LogTheme.Foreground(Color256.Magenta164);

    protected override string LevelDebug => LogTheme.Background(Color.CadetBlue).FormatType(FormatTypeEnum.BoldMode);

    // You can also use a simple Style() constructor to set the properties in one go
    protected override string Name => LogTheme.Style(Color.Salmon, Color.Azure);

    // Or use short hand functions for setting the format
    protected override string LevelError => LogTheme.Bold().Italic().Strikethrough().Foreground(Color.Red);
}
```




# Resources

 - See this interesting ANSI Escape Sequences article about [color codes](https://gist.github.com/fnky/458719343aabd01cfb17a3a4f7296797#color-codes) and [text formatting](https://gist.github.com/fnky/458719343aabd01cfb17a3a4f7296797#colors--graphics-mode)

# Contributions

PR's are very welcome, got a cool idea for a theme than just create a PR for it!