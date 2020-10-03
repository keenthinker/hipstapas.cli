using System;

public static class HipstapasApi
{
    private const string baseUrl = @"https://hipstapas.dev/api";
    static Func<string, string> endpointUrl = endpoint => String.Format("{0}/{1}", baseUrl, endpoint);

    public static string GeneratePassword(this CliOptionsPassword options)
    {
        return callApi("index", options);
    }

    public static string GenerateUuid(this CliOptionsUuid options)
    {
        return callApi("uuid", options);
    }

    public static string GenerateWordlist(this CliOptionsWordlist options)
    {
        return callApi("wordlist", options);
    }

    private static string callApi<T>(string endpointName, T options)
    {
        return endpointUrl(endpointName)
                .QueryWith(options)
                .DownloadString();
    }
}