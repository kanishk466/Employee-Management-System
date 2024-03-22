namespace Employee_Management_System.Models
{
    public interface IEmsDatabaseSetting
    {
        string UserCollectionName { get; set; }
        string EmployeeCollectionName { get; set; }

        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
