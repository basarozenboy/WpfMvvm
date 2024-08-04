using WpfMvvm.State.Navigators;

namespace WpfMvvm.ViewModels.Factories
{
    public interface IWpfMvvmViewModelFactory
    {
        ViewModelBase CreateViewModel(ViewType viewType);
    }
}
