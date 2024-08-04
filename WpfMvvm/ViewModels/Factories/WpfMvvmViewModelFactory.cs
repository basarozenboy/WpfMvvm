using WpfMvvm.State.Navigators;
using WpfMvvm.ViewModels;
using WpfMvvm.ViewModels.Factories;

namespace WpfMvvm.Factories
{
    public class WpfMvvmViewModelFactory : IWpfMvvmViewModelFactory
    {
        private readonly CreateViewModel<RadarsViewModel> _createRadarsViewModel;
        private readonly CreateViewModel<PlatformsViewModel> _createPlatformsViewModel;

        public WpfMvvmViewModelFactory(CreateViewModel<RadarsViewModel> createRadarsViewModel,
            CreateViewModel<PlatformsViewModel> createPlatformsViewModel)
        {
            _createRadarsViewModel = createRadarsViewModel;
            _createPlatformsViewModel = createPlatformsViewModel;
        }

        public ViewModelBase CreateViewModel(ViewType viewType)
        {
            switch (viewType)
            {
                case ViewType.Radars:
                    return _createRadarsViewModel();
                case ViewType.Platforms:
                    return _createPlatformsViewModel();
                default:
                    throw new ArgumentException("The ViewType does not have a ViewModel.", "viewType");
            }
        }
    }
}
