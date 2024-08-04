using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMvvm.ViewModels
{
    public class PlatformItemViewModel: ViewModelBase
    {
        public string Name { get; }
        public string Description { get; }

        public PlatformItemViewModel(string Name, string Description)
        {
            this.Name = Name;
            this.Description = Description;
        }
    }
}
