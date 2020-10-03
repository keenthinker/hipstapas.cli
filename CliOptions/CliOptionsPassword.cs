using System.Collections.Generic;
using CommandLine;
using CommandLine.Text;

[Verb("password", HelpText = "Generate a strong phrase")]
public class CliOptionsPassword : CliOptions
{
    [Option(Default = (bool)true)]
    public bool? AlphabetSmall { get; set; }

    [Option(Default = (bool)true)]
    public bool? AlphabetCapital { get; set; }

    [Option(Default = (bool)true)]
    public bool? AlphabetNumber { get; set; }

    [Option(Default = (bool)true)]
    public bool? AlphabetSpecial { get; set; }

    [Option(Default = (int)16)]
    public int LengthMin { get; set; }

    [Option(Default = (int)32)]
    public int LengthMax { get; set; }

    [Usage(ApplicationAlias = "hipstapas.cli")]
    public static IEnumerable<Example> Examples
    {
        get
        {
            return new List<Example>() {
                        new Example("Generate exactly one password, that does not contain special characters", new CliOptionsPassword { ResultsCount = 1, AlphabetSpecial = false })
                };
        }
    }
}