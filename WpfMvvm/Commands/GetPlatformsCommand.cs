using Services;
using System.ComponentModel;
using WpfMvvm.ViewModels;

namespace WpfMvvm.Commands
{
    public class GetPlatformsCommand : AsyncCommandBase
    {
        private readonly PlatformsViewModel platformsViewModel;

        public GetPlatformsCommand(PlatformsViewModel platformsViewModel)
        {
            this.platformsViewModel = platformsViewModel;
            this.platformsViewModel.PropertyChanged += PlatformsViewModel_PropertyChanged;
        }

        public override bool CanExecute(object parameter)
        {
            return base.CanExecute(parameter);
        }

        public override async Task ExecuteAsync(object parameter)
        {
            platformsViewModel.PlatformListViewModel.UpdatePlatformList();
        }

        private void PlatformsViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            //if (e.PropertyName == nameof(platformsViewModel.CanBuyStock))
            //{
            //    OnCanExecuteChanged();
            //}
        }
    }
}
