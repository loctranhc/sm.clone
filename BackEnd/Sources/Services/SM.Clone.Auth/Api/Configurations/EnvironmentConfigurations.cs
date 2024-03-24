namespace Api.Configurations
{
    public static class EnvironmentConfigurations
    {
        public static void Load(ConfigurationManager configuration)
        {
            var environment = configuration["ASPNETCORE_ENVIRONMENT"];
            var filePath = GetAppSettingsFilePath(environment);

            if (string.IsNullOrEmpty(filePath))
            {
                throw new Exception("appsettings.json is not found.");
            }

            configuration.AddJsonFile(filePath)
                    .AddEnvironmentVariables()
                    .Build();
        }

        private static string? GetAppSettingsFilePath(string? environment)
        {
            var fileName = $"appsettings.json";

            if (!string.IsNullOrEmpty(environment))
            {
                fileName = $"appsettings.{environment}.json";
            }

            return Directory.GetFiles(
                Directory.GetCurrentDirectory(),
                fileName,
                searchOption: SearchOption.AllDirectories).FirstOrDefault();
        }
    }
}