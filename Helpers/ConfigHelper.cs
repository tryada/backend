namespace Backend.Helpers;

public static class ConfigHelper 
{
    public static string GetValue(ConfigurationManager configuration, string key)
    {
        var result = configuration.GetValue<string>(key);
        if (string.IsNullOrWhiteSpace(result))
            throw new ArgumentException($"Missing value, key: {key} in appsettings.json file ");

        return result;
    }
}