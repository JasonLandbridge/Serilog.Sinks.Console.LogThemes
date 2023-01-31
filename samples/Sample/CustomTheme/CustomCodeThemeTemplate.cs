using System.Drawing;
using Serilog.Sinks.Console.LogThemes;

namespace Sample.CustomTheme;

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