using System.Collections.Generic;
using CommandLine;
using CommandLine.Text;

[Verb("wordlist", HelpText = "Generate a passphrase using the EFF wordlists")]
public class CliOptionsWordlist : CliOptions
{
    [Option(Default = (int)6, HelpText = "The count of the generated words")]
    public int Words { get; set; }

    [Usage(ApplicationAlias = "hipstapas.cli")]
    public static IEnumerable<Example> Examples
    {
        get
        {
            return new List<Example>() {
                        new Example("Generate EFF passphrases each containing exactly 3 words", new CliOptionsWordlist { Words = 3 })
                };
        }
    }
}