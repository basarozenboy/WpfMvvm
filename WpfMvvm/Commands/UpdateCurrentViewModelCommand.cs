using System.Windows.Input;
using WpfMvvm.State.Navigators;
using WpfMvvm.ViewModels;
using WpfMvvm.ViewModels.Factories;

namespace SimpleTrader.WPF.Commands
{
    public class UpdateCurrentViewModelCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private readonly INavigator _navigator;
        private readonly IWpfMvvmViewModelFactory _viewModelFactory;

        public UpdateCurrentViewModelCommand(INavigator navigator, IWpfMvvmViewModelFactory viewModelFactory)
        {
            _navigator = navigator;
            _viewModelFactory = viewModelFactory;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if(parameter is ViewType)
            {
                ViewType viewType = (ViewType)parameter;

                if (_navigator.CurrentViewModel is not null &&
                    (_navigator.CurrentViewModel is PlatformsViewModel && viewType == ViewType.Platforms) ||
                    (_navigator.CurrentViewModel is RadarsViewModel && viewType == ViewType.Radars))
                {
                    return;
                }

                _navigator.CurrentViewModel = _viewModelFactory.CreateViewModel(viewType);
            }
        }
    }
}