namespace Api.Configurations
{
    public static class EnvironmentConfigurations
    {
        private static string _defaultFileName = $"appsettings.json";
        public static void Load(ConfigurationManager configuration)
        {
            var environment = configuration["ASPNETCORE_ENVIRONMENT"];
            var filePath = GetAppSettingsFilePath(environment);

            if (string.IsNullOrEmpty(filePath))
            {
                throw new Exception($"environment: {environment}, FilePath: {filePath}, appsettings.json is not found.");
            }

            configuration.AddJsonFile(filePath)
                    .AddEnvironmentVariables()
                    .Build();
        }

        private static string? GetAppSettingsFilePath(string? environment)
        {
            var fileName = _defaultFileName;
            var defaultFilePath = Directory.GetFiles(
                Directory.GetCurrentDirectory(),
                fileName,
                searchOption: SearchOption.AllDirectories).FirstOrDefault();
            var filePath = defaultFilePath;

            if (!string.IsNullOrEmpty(environment))
            {
                fileName = $"appsettings.{environment}.json";
                filePath = Directory.GetFiles(
                    Directory.GetCurrentDirectory(),
                    fileName,
                    searchOption: SearchOption.AllDirectories).FirstOrDefault();
            }

            if (string.IsNullOrEmpty(filePath))
            {
                return defaultFilePath;
            }
            else
            {
                return filePath;
            }
        }
    }
}