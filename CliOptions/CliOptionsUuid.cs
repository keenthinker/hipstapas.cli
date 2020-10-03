using System.Collections.Generic;
using CommandLine;
using CommandLine.Text;

[Verb("uuid", HelpText = "Generate a v4 UUID / GUID")]
public class CliOptionsUuid : CliOptions
{
    [Usage(ApplicationAlias = "hipstapas.cli")]
    public static IEnumerable<Example> Examples
    {
        get
        {
            return new List<Example>() {
                        new Example("Generate new uuid's using the default value for the results count option", new CliOptionsUuid())
                };
        }
    }
}