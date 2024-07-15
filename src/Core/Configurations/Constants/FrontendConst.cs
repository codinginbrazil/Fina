namespace Core.Configurations.Constants;

public static class FrontendConst
{
    public static string Host { get; set; } = Constant.Host;
    public static string Port { get; set; } = "5200";
    public static string Url { get; set; } = Host + ":" + Port;
}
