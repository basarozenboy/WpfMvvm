
using Core.Models;
using Services;
using System.Windows.Input;
using WpfMvvm.Commands;

namespace WpfMvvm.ViewModels
{
    public class PlatformsViewModel : ViewModelBase
    {
        private Platforms plaforms;
        private IPlatformService platformService;
        public PlatformListViewModel PlatformListViewModel { get; }
        public ICommand GetPlatformsCommand { get; set; }

        public PlatformsViewModel(IPlatformService platformService)
        {
            this.platformService = platformService;
            Info = platformService.GetPlatformsInfo();
            PlatformListViewModel = new(platformService);
            GetPlatformsCommand = new GetPlatformsCommand(this);
        }

        private string info;
        public string Info
        {
            get
            {
                return info;
            }
            set
            {
                info = value;
                OnPropertyChanged(nameof(Info));
            }
        }

        public override void Dispose()
        {
            PlatformListViewModel.Dispose();
            base.Dispose();
        }
    }
}
