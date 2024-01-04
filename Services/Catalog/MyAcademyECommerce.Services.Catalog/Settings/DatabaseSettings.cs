namespace MyAcademyECommerce.Services.Catalog.Settings
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string Category { get; set; }
        public string Product { get; set; }
    }
}
