using System.Collections.Generic;
using CommandLine;
using CommandLine.Text;

[Verb("random", HelpText = "Generate a random number or a sequence of random numbers")]
public class CliOptionsRandom : CliOptions
{
    [Option(Default = (int)1, HelpText = "Lower bound of the generated number")]
    public int Min { get; set; }

    [Option(Default = (int)1048576, HelpText = "Upper bound of the generated number")]
    public int Max { get; set; }

    [Option(Default = (bool)false, HelpText = "The generated number sequence should contain only unique numbers")]
    public bool? NoDuplicates { get; set; }

    [Option(Default = (bool)false, HelpText = "The generated number sequence should be sorted")]
    public bool? Sort { get; set; }

    [Usage(ApplicationAlias = "hipstapas.cli")]
    public static IEnumerable<Example> Examples
    {
        get
        {
            return new List<Example>() {
                        new Example("Generate a sequence containing random numbers that are sorted, duplicates are allowed and every number is between 1 and 100", new CliOptionsRandom { Min = 1, Max = 100, NoDuplicates = false, Sort = true })
                };
        }
    }
}