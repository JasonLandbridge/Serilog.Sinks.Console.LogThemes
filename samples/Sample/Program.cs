// See https://aka.ms/new-console-template for more information


using Sample.CustomTheme;
using Serilog;
using Serilog.Sinks.Console.LogThemes;
using Serilog.Sinks.Console.LogThemes.Demo;

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console(theme: LogThemes.UseAnsiTheme<CustomCodeThemeTemplate>()) // <= Select ANSI theme here
    //.WriteTo.Console(theme: LogThemes.UseSystemConsoleTheme<CustomCodeThemeTemplate>()) // <= Or select System Console theme here
    .CreateLogger();



// Predefined theme test
await LogThemeDemo.TestTheme(LogThemes.Sixteen);

// Custom theme test
var theme = LogThemes.UseAnsiTheme<CustomCodeThemeTemplate>();
await LogThemeDemo.TestTheme(theme);



await LogThemeDemo.TestAllThemes();

await LogThemeDemo.TasteTheRainbow(config =>
{
    config.Loops = 30;
    config.RandomForeground = true;
    config.RandomBackground = false;
    config.RandomFormatType = true;
    config.UseColor256 = false;
});