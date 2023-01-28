using Serilog.Sinks.Console.LogThemes;

namespace Sample.CustomTheme;

public class CustomCodeThemeTemplate : CodeAnsiThemeTemplate
{
    protected override string Text { get; } = LogTheme.Foreground(Color256.Magenta164);
}