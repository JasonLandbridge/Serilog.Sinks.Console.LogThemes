// See https://aka.ms/new-console-template for more information


using Sample.CustomTheme;
using Serilog;
using Serilog.Sinks.Console.LogThemes;

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console(theme: LogThemes.UseAnsiTheme<CustomAnsiTheme>()) // <= Select theme here
    .CreateLogger();

Log.Information("Hello, world!");

Console.WriteLine("Hello, World!");