namespace Serilog.Sinks.Console.LogThemes
{
    public class GrayscaleAnsiThemeTemplate : AnsiBaseTheme
    {
        protected override string Text => LogTheme.Foreground(Color16.WhiteBold);
        protected override string SecondaryText => LogTheme.Foreground(Color16.White);
        protected override string TertiaryText => LogTheme.Foreground(Color16.BlackBold);
        protected override string Invalid => LogTheme.Style(Color16.WhiteBold, Color16.White);
        protected override string Null => LogTheme.Bold().Foreground(Color16.WhiteBold);
        protected override string Name => LogTheme.Foreground(Color16.White);
        protected override string String => LogTheme.Bold().Foreground(Color16.WhiteBold);
        protected override string Number => LogTheme.Bold().Foreground(Color16.WhiteBold);
        protected override string Boolean => LogTheme.Bold().Foreground(Color16.WhiteBold);
        protected override string Scalar => LogTheme.Bold().Foreground(Color16.WhiteBold);
        protected override string LevelVerbose => LogTheme.Foreground(Color16.BlackBold);
        protected override string LevelDebug => LogTheme.Foreground(Color16.BlackBold);
        protected override string LevelInformation => LogTheme.Foreground(Color16.WhiteBold);
        protected override string LevelWarning => LogTheme.Style(Color16.WhiteBold, Color16.White);
        protected override string LevelError => LogTheme.Style(Color16.Black, Color16.White);
        protected override string LevelFatal => LogTheme.Style(Color16.Black, Color16.White);
    }
}