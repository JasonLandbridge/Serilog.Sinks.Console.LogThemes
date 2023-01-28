using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Bogus;
using Bogus.DataSets;
using Serilog.Sinks.SystemConsole.Themes;

namespace Serilog.Sinks.Console.LogThemes.UnitTests
{
    public static partial class FakeData
    {
        public static Faker<AnsiConsoleTheme> GetFakeTheme(int seed = 0)
        {
            return new Faker<AnsiConsoleTheme>()
                .UseSeed(seed)
                .CustomInstantiator(faker =>
                {
                    var styles = GetFakeLogStyle(seed, true).Generate(16);
                    var dict = new Dictionary<ConsoleThemeStyle, string>
                    {
                        // Timestamp, classname, method name and line number
                        [ConsoleThemeStyle.SecondaryText] = styles[0],

                        // Brackets, dots and colons
                        [ConsoleThemeStyle.TertiaryText] = styles[1],

                        // Log message
                        [ConsoleThemeStyle.Text] = styles[2],

                        [ConsoleThemeStyle.Invalid] = styles[3],
                        [ConsoleThemeStyle.Null] = styles[4],
                        [ConsoleThemeStyle.Name] = styles[5],

                        // Log values
                        [ConsoleThemeStyle.String] = styles[6],
                        [ConsoleThemeStyle.Number] = styles[7],
                        [ConsoleThemeStyle.Boolean] = styles[8],
                        [ConsoleThemeStyle.Scalar] = styles[9],

                        // Log Level coloring
                        // [ConsoleThemeStyle.LevelVerbose] = styles[10],
                        // [ConsoleThemeStyle.LevelDebug] = styles[11],
                        // [ConsoleThemeStyle.LevelInformation] = styles[12],
                        // [ConsoleThemeStyle.LevelWarning] = styles[13],
                        // [ConsoleThemeStyle.LevelError] = styles[14],
                        // [ConsoleThemeStyle.LevelFatal] = styles[15],

                        // Log Level coloring
                        [ConsoleThemeStyle.LevelVerbose] = LogTheme.Style(Color.White, Color.DarkGray),
                        [ConsoleThemeStyle.LevelDebug] = LogTheme.Style(Color.White, Color.DarkGray),
                        [ConsoleThemeStyle.LevelInformation] = LogTheme.Style(Color.White, Color.FromArgb(23, 126, 137)),
                        [ConsoleThemeStyle.LevelWarning] = LogTheme.Style(Color.Black, Color.FromArgb(255, 200, 87)),
                        [ConsoleThemeStyle.LevelError] = LogTheme.Style(Color.White, Color.Red),
                        [ConsoleThemeStyle.LevelFatal] = LogTheme.Style(Color.White, Color.DarkRed),
                    };
                    return new AnsiConsoleTheme(dict);
                });
        }

        public static Faker<string> GetFakeLogStyle(int seed = 0, bool foreGround = false, bool background = false)
        {
            return new Faker<string>()
                .UseSeed(seed)
                .CustomInstantiator(faker =>
                {

                        var colorString = faker.Internet.Color(format: ColorFormat.Delimited).Split(',').Select(int.Parse).ToList();
                        var foreGroundColor = Color.FromArgb(colorString[0], colorString[1], colorString[2]);



                        colorString = faker.Internet.Color(format: ColorFormat.Delimited).Split(',').Select(int.Parse).ToList();
                        var backgroundColor =  Color.FromArgb(colorString[0], colorString[1], colorString[2]);


                    var formatType = faker.Random.Enum<FormatTypeEnum>();
                    return LogThemeBuilder.ToTheme(foreGroundColor, backgroundColor, formatType);
                });
        }
    }
}