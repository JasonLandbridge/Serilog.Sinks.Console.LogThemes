// See https://aka.ms/new-console-template for more information


using Sample.CustomTheme;
using Serilog;
using Serilog.Sinks.Console.LogThemes;
using Serilog.Sinks.Console.LogThemes.Demo;

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console(theme: LogThemes.UseAnsiTheme<CustomCodeThemeTemplate>()) // <= Select theme here
    .CreateLogger();

await LogThemeDemo.TestTheme(LogThemes.Empty);

await LogThemeDemo.TestAllThemes();

await LogThemeDemo.TasteTheRainbow(config =>
{
    config.Loops = 30;
    config.RandomForeground = true;
    config.RandomBackground = false;
    config.RandomFormatType = true;
    config.UseColor256 = false;
});