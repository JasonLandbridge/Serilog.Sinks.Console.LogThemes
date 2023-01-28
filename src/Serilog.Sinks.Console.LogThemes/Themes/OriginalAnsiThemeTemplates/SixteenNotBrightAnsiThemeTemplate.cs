namespace Serilog.Sinks.Console.LogThemes
{
    public class SixteenNotBrightAnsiThemeTemplate : SixteenAnsiThemeTemplate
    {
        protected override string LevelInformation => LogTheme.Foreground(Color16.Cyan);
        protected override string LevelWarning => LogTheme.Foreground(Color16.Yellow);
        protected override string LevelError => LogTheme.Foreground(Color16.Red);
        protected override string LevelFatal => LogTheme.Foreground(Color16.Red);
    }
}