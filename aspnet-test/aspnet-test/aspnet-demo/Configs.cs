namespace aspnet_demo;

public class Configs
{
   public static AsyncLocal<string> LocalValue = new AsyncLocal<string>();
   public static AsyncLocal<string> PathPattern = new AsyncLocal<string>();
}