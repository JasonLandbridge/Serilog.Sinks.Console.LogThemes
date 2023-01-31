using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Serilog.Sinks.SystemConsole.Themes;

namespace Serilog.Sinks.Console.LogThemes.Demo.Helpers
{
    internal static class ThemeGenerator
    {
        private static readonly Random _rnd = new Random();

        private static Color GetColor()
        {
            return Color.FromArgb(_rnd.Next(0, 256), _rnd.Next(0, 256), _rnd.Next(0, 256));
        }

        private static Color256 GetColor256()
        {
            return (Color256)_rnd.Next(0, 256);
        }

        private static FormatTypeEnum GetFormat()
        {
            var values = Enum.GetValues(typeof(FormatTypeEnum));
            return (FormatTypeEnum)(values.GetValue(_rnd.Next(values.Length)) ?? FormatTypeEnum.None);
        }

        private static string GenerateStyle(ConsoleThemeStyle themeStyle, Action<LogThemeDemoConfig>? options = null)
        {
            var config = FromOptions(options);

            var debugStringBuilder = new StringBuilder();

            var enumName = Enum.GetName(typeof(ConsoleThemeStyle), themeStyle);
            debugStringBuilder.Append($"Style [{enumName}]: [");

            var styleString = string.Empty;
            if (config.UseColor256)
            {
                if (config.RandomForeground)
                {
                    var color = GetColor256();
                    styleString += LogTheme.Foreground(color);
                    debugStringBuilder.Append($"Foreground: Color256.{Enum.GetName(typeof(Color256), color)} - ");
                }

                if (config.RandomBackground)
                {
                    var color = GetColor256();
                    styleString += LogTheme.Background(color);
                    debugStringBuilder.Append($"Background: Color256.{Enum.GetName(typeof(Color256), color)} - ");
                }
            }
            else
            {
                if (config.RandomFormatType)
                {
                    var format = GetFormat();
                    styleString += LogTheme.FormatType(format);
                    debugStringBuilder.Append($"Format: {Enum.GetName(typeof(FormatTypeEnum), format)}");
                    if (config.RandomForeground)
                    {
                        debugStringBuilder.Append(" - ");
                    }
                }

                if (config.RandomForeground)
                {
                    var color = GetColor();
                    styleString += LogTheme.Foreground(color);
                    debugStringBuilder.Append($"Foreground: ColorRGB.{color.ToString()}");
                    if (config.RandomBackground)
                    {
                        debugStringBuilder.Append(" - ");
                    }
                }

                if (config.RandomBackground)
                {
                    var color = GetColor();
                    styleString += LogTheme.Background(color);
                    debugStringBuilder.Append($"Background: ColorRGB.{color.ToString()}");
                }
            }

            debugStringBuilder.Append($"] - Output: {styleString.Replace(LogThemeBuilder.Esc, "")}");

            System.Console.WriteLine(debugStringBuilder.ToString());

            return styleString;
        }


        internal static LogThemeDemoConfig FromOptions(Action<LogThemeDemoConfig>? action = null)
        {
            var config = new LogThemeDemoConfig();
            action?.Invoke(config);
            return config;
        }

        internal static AnsiConsoleTheme GenerateTheme(Action<LogThemeDemoConfig>? options = null)
        {
            System.Console.WriteLine(Environment.NewLine + "New theme start:");

            var dict = new Dictionary<ConsoleThemeStyle, string>
            {
                [ConsoleThemeStyle.Text] = GenerateStyle(ConsoleThemeStyle.Text, options),
                [ConsoleThemeStyle.SecondaryText] = GenerateStyle(ConsoleThemeStyle.SecondaryText, options),
                [ConsoleThemeStyle.TertiaryText] = GenerateStyle(ConsoleThemeStyle.TertiaryText, options),
                [ConsoleThemeStyle.Invalid] = GenerateStyle(ConsoleThemeStyle.Invalid, options),
                [ConsoleThemeStyle.Null] = GenerateStyle(ConsoleThemeStyle.Null, options),
                [ConsoleThemeStyle.Name] = GenerateStyle(ConsoleThemeStyle.Name, options),
                [ConsoleThemeStyle.String] = GenerateStyle(ConsoleThemeStyle.String, options),
                [ConsoleThemeStyle.Number] = GenerateStyle(ConsoleThemeStyle.Number, options),
                [ConsoleThemeStyle.Boolean] = GenerateStyle(ConsoleThemeStyle.Boolean, options),
                [ConsoleThemeStyle.Scalar] = GenerateStyle(ConsoleThemeStyle.Scalar, options),
                [ConsoleThemeStyle.LevelVerbose] = GenerateStyle(ConsoleThemeStyle.LevelVerbose, options),
                [ConsoleThemeStyle.LevelDebug] = GenerateStyle(ConsoleThemeStyle.LevelDebug, options),
                [ConsoleThemeStyle.LevelInformation] = GenerateStyle(ConsoleThemeStyle.LevelInformation, options),
                [ConsoleThemeStyle.LevelWarning] = GenerateStyle(ConsoleThemeStyle.LevelWarning, options),
                [ConsoleThemeStyle.LevelError] = GenerateStyle(ConsoleThemeStyle.LevelError, options),
                [ConsoleThemeStyle.LevelFatal] = GenerateStyle(ConsoleThemeStyle.LevelFatal, options),
            };
            return new AnsiConsoleTheme(dict);
        }
    }
}