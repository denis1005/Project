namespace MyWebAppProject.Web.ViewModels.Settings
{
    using MyWebAppProject.Data.Models;
    using MyWebAppProject.Services.Mapping;

    public class SettingViewModel : IMapFrom<Setting>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }
    }
}
