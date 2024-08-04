using Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMvvm.ViewModels
{
    public class PlatformListViewModel: ViewModelBase
    {
        private readonly ObservableCollection<PlatformItemViewModel> platformList;
        public IEnumerable<PlatformItemViewModel> PlatformList => platformList;
        private IPlatformService platformService;

        public PlatformListViewModel(IPlatformService platformService)
        {
            this.platformService = platformService;
            platformList = new ObservableCollection<PlatformItemViewModel>();
            UpdatePlatformList();
        }
        
        public void UpdatePlatformList()
        {
            var platformsModel = this.platformService.GetPlatformsModel();
            platformList.Clear();
            foreach (var platform in platformsModel.PlaformList)
            {
                var platformItemViewModel = new PlatformItemViewModel(platform.Name, platform.Description);
                platformList.Add(platformItemViewModel);
            }
        }

        private void DisposeAssets()
        {
            foreach (var item in platformList)
            {
                item.Dispose();
            }
        }

        public override void Dispose()
        {
            DisposeAssets();
            base.Dispose();
        }
    }
}
