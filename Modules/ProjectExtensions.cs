
using System;
using System.Net;

public static class ProjectExtensions
{
    public static string DownloadString(this string url)
	{
		using (var webClient = new WebClient())
		{
			var response = String.Empty;
			webClient.Headers.Add(HttpRequestHeader.UserAgent, "hipstapas.cli");
			try
			{
				response = webClient.DownloadString(url);	
			}
			catch (System.Exception exception)
			{
				response = "Uh oh, something went wrong :-(";
				// todo: log to file if specified
				Console.WriteLine(exception.Message);
			}
			return response;
		}
	}

	public static string QueryWith<T>(this string url, T options)
	{
        var query = String.Empty;
		var ifVerboseIsOn = false;

        switch(options)
        {
            case CliOptionsPassword optionsPassword: 
                query = $"?lengthMin={optionsPassword.LengthMin}&lengthMax={optionsPassword.LengthMax}&resultsCount={optionsPassword.ResultsCount}&alphabetSmall={optionsPassword.AlphabetSmall.StringifyToLower()}&alphabetCapital={optionsPassword.AlphabetCapital.StringifyToLower()}&alphabetNumber={optionsPassword.AlphabetNumber.StringifyToLower()}&alphabetSpecial={optionsPassword.AlphabetSpecial.StringifyToLower()}";
                ifVerboseIsOn = optionsPassword.Verbose;
				break;

            case CliOptionsUuid optionsUuid: 
                query = $"?resultsCount={optionsUuid.ResultsCount}";
				ifVerboseIsOn = optionsUuid.Verbose;
                break;

            case CliOptionsWordlist optionsWordlist: 
                query = $"?words={optionsWordlist.Words}&resultsCount={optionsWordlist.ResultsCount}";
                ifVerboseIsOn = optionsWordlist.Verbose;
				break;

            default:
                throw new InvalidCastException($"Not supported type {options.GetType().Name}");
        }
    
		var apiQuery = String.Format("{0}{1}", url, query);

	    return apiQuery.WriteToConsole(ifVerboseIsOn);
	}

	public static string StringifyToLower(this bool? b)
	{
		return b.ToString().ToLower();
	}

    public static string WriteToConsole(this string s, bool printCondition = true)
    {
		if (printCondition)
		{
        	Console.WriteLine(s);
		}
        return s;
    }
}