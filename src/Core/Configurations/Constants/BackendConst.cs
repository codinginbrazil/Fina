namespace Core.Configurations.Constants;

public static class BackendConst
{
    public static string Host { get; set; } = Constant.Host;
    public static string Port { get; set; } = "7273";
    public static string Url { get; set; } = Host + ":" + Port;
}
