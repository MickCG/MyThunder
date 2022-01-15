namespace MyThunder.ViewModels
{
    using MyThunder.Services;

    public class MainViewModel : ViewModelBase
    {
        public MainViewModel(DataService dataService, IConventionalService conventionalService, IPlatformService platformService)
        {
            this.DataService = dataService;
            this.ConventionalService = conventionalService;
            this.PlatformService = platformService;
        }

        public DataService DataService { get; }
        public IConventionalService ConventionalService { get; }
        public IPlatformService PlatformService { get; }

    }
}
