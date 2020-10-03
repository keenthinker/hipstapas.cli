using System.Collections.Generic;
using CommandLine;


namespace hipstapas.cli
{
    class Program
    {
        // https://docs.microsoft.com/de-de/dotnet/core/deploying/
        // https://docs.microsoft.com/de-de/dotnet/core/deploying/deploy-with-cli

        // https://docs.microsoft.com/de-de/contribute/dotnet/dotnet-contribute

        // dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true -p:PublishTrimmed=true
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<CliOptionsPassword, CliOptionsUuid, CliOptionsWordlist>(args)
            .WithParsed<CliOptionsPassword>(passwordOptions => passwordOptions.GeneratePassword().WriteToConsole())
            .WithParsed<CliOptionsUuid>(uuidOptions => uuidOptions.GenerateUuid().WriteToConsole())
            .WithParsed<CliOptionsWordlist>(wordlistOptions => wordlistOptions.GenerateWordlist().WriteToConsole())
            .WithNotParsed(errors => handleErrors(errors));
        }

        private static void handleErrors(IEnumerable<Error> errors)
        {
            // NOP
        }
    }
}
