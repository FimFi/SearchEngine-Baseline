namespace Common
{
    public static class Config
    {
        public static string DatabasePath { get; } = "E:/Work/LargeSystems/database.db";
        public static string DataSourcePath { get; } = "E:/Work/LargeSystems/maildir";
        public static int NumberOfFoldersToIndex { get; } = 1; // Use 0 or less for indexing all folders
    }
}