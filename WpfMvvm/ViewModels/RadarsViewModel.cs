
using Core.Models;

namespace WpfMvvm.ViewModels
{
    public class RadarsViewModel : ViewModelBase
    {
        private Radars radars;

        public RadarsViewModel()
        {
            Info = "test";
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
            base.Dispose();
        }
    }
}
