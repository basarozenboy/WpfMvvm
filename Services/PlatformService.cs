using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class PlatformService : IPlatformService
    {
        public string GetPlatformsInfo()
        {
            return "PlatformInfo";
        }

        public Platforms GetPlatformsModel()
        {
            var platforms = new Platforms();
            platforms.PlaformList = new();
            platforms.PlaformList.Add(new Platform() { Name = "Platform Name", Description = "Desc1" });
            platforms.PlaformList.Add(new Platform() { Name = "Platform Name2", Description = "Desc2" });
            return platforms;
        }
    }
}
