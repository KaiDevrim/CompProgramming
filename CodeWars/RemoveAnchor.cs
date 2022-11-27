namespace CodeWars;

public class RemoveAnchor
{
    public static string RemoveUrlAnchor(string url)
    {
        if (!url.Contains('#')) return url;

        return url.Substring(0, url.IndexOf('#'));
    }
}