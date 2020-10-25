# hipstapas.cli
Hipster Password Helper As A Service Command Line Interface

This is a companion app for the <a href="https://hipstapas.dev">hipstapas.dev</a> service. It allows the use of the service directly from the terminal. 

It is build with C# so that it can run on any operating system that supports .NET Core.

Usage: 

`hipstapas.cli [verb] [--option1=v1 --option2=v2 ...]`

* Verbs are mandatory
* Options are not required and can be combined. Every verb has it's own options. Option value can be set in two ways: `--option=value` or `--option value` 
* The `--resultscount=n` option is available for each verb

Verbs and options:
* password
    * alphabetsmall (boolean, default: true)
    * alphabetcapital (boolean, default: true)
    * alphabetnumber (boolean, default: true)
    * alphabetspecial (boolean, default: true)
    * lengthmin (int, default: 16)
    * lengthmax (int, default: 32)
    * resultscount (int, default: 5)
* uuid
    * resultscount (int, default: 5)
* wordlist
    * word (int, default: 6)
    * resultscount (int, default: 5)
* random
    * min (int. default: 1)
    * max (int, default: 1048576)
    * noduplicates (boolean, default: false)
    * sort (boolean, default: false)
    * resultscount (int, default: 5)
* help
* version

Build:
* Download the source code and extract it
* Build the project with `dotnet build`
* Start using it, e.g. `dotnet run password` or `dotnet run wordlist --resultscount 1`
* Alternative usage: navigate to the bin directory and call the executable `hipstapas.cli password` or `hipstapas.cli wordlist --resultcount 1`  

Dependencies: 
* [.NET Core 3.1](https://dotnet.microsoft.com/)
* [Command Line Parser Library](https://github.com/commandlineparser/commandline)