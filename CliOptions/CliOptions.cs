using CommandLine;

public class CliOptions
{
    [Option(Default = (int)5, HelpText = "Set how many items are generated and returned at ones")]
    public int ResultsCount { get; set; }

    [Option(Default = (bool)false, HelpText = "Display the API query")]
    public bool Verbose { get; set; }
}