using Service.Base.Enums;

namespace Service.Base.ViewModels.Others
{
    public class DatabaseConnection
    {
        public DatabaseTypeOption DatabaseType { get; set; }
        public string ConnectionString { get; set; } = string.Empty;
        public Guid CompanyKey { get; set; }
    }
}
