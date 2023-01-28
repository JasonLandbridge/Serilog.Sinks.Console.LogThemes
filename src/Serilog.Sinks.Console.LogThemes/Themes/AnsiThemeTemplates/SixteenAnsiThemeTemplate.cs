namespace Serilog.Sinks.Console.LogThemes
{
    public class SixteenAnsiThemeTemplate : AnsiBaseTheme
    {
        protected override string Text => LogTheme.Unthemed;
        protected override string SecondaryText => LogTheme.Unthemed;
        protected override string TertiaryText => LogTheme.Unthemed;
        protected override string Invalid => LogTheme.Foreground(Color16.Yellow);
        protected override string Null => LogTheme.Foreground(Color16.Blue);
        protected override string Name => LogTheme.Unthemed;
        protected override string String => LogTheme.Foreground(Color16.Cyan);
        protected override string Number => LogTheme.Foreground(Color16.Magenta);
        protected override string Boolean => LogTheme.Foreground(Color16.Blue);
        protected override string Scalar => LogTheme.Foreground(Color16.Green);
        protected override string LevelVerbose => LogTheme.Unthemed;
        protected override string LevelDebug => LogTheme.Bold();
        protected override string LevelInformation => LogTheme.Foreground(Color16.CyanBold);
        protected override string LevelWarning => LogTheme.Foreground(Color16.YellowBold);
        protected override string LevelError => LogTheme.Foreground(Color16.RedBold);
        protected override string LevelFatal => LogTheme.Foreground(Color16.RedBold);
    }
}