namespace Serilog.Sinks.Console.LogThemes
{
    public class LiterateAnsiThemeTemplate : AnsiBaseTheme
    {
        protected override string Text => LogTheme.Foreground(Color256.BrightWhite15);
        protected override string SecondaryText => LogTheme.Foreground(Color256.White7);
        protected override string TertiaryText => LogTheme.Foreground(Color256.BrightBlack8);
        protected override string Invalid => LogTheme.Foreground(Color256.BrightYellow11);
        protected override string Null => LogTheme.Foreground(Color256.DodgerBlue27);
        protected override string Name => LogTheme.Foreground(Color256.White7);
        protected override string String => LogTheme.Foreground(Color256.Turquoise45);
        protected override string Number => LogTheme.Foreground(Color256.Magenta200);
        protected override string Boolean => LogTheme.Foreground(Color256.DodgerBlue27);
        protected override string Scalar => LogTheme.Foreground(Color256.SeaGreen85);
        protected override string LevelVerbose => LogTheme.Foreground(Color256.White7);
        protected override string LevelDebug => LogTheme.Foreground(Color256.White7);
        protected override string LevelInformation => LogTheme.Foreground(Color256.BrightWhite15);
        protected override string LevelWarning => LogTheme.Foreground(Color256.BrightYellow11);
        protected override string LevelError => LogTheme.Style(Color256.BrightWhite15, Color256.Red196);
        protected override string LevelFatal => LogTheme.Style(Color256.BrightWhite15, Color256.Red196);
    }
}