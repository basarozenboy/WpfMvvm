using WpfMvvm.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace WpfMvvm.State.Navigators
{
    public enum ViewType
    {
        Platforms,
        Radars
    }

    public interface INavigator
    {
        ViewModelBase CurrentViewModel { get; set; }
        event Action StateChanged;
    }
}
