namespace Serilog.Sinks.Console.LogThemes
{
    public class EmptyAnsiThemeTemplate : AnsiBaseTheme
    {
        protected override string Text => LogTheme.Unthemed;
        protected override string SecondaryText => LogTheme.Unthemed;
        protected override string TertiaryText => LogTheme.Unthemed;
        protected override string Invalid => LogTheme.Unthemed;
        protected override string Null => LogTheme.Unthemed;
        protected override string Name => LogTheme.Unthemed;
        protected override string String => LogTheme.Unthemed;
        protected override string Number => LogTheme.Unthemed;
        protected override string Boolean => LogTheme.Unthemed;
        protected override string Scalar => LogTheme.Unthemed;
        protected override string LevelVerbose => LogTheme.Unthemed;
        protected override string LevelDebug => LogTheme.Unthemed;
        protected override string LevelInformation => LogTheme.Unthemed;
        protected override string LevelWarning => LogTheme.Unthemed;
        protected override string LevelError => LogTheme.Unthemed;
        protected override string LevelFatal => LogTheme.Unthemed;
    }
}