using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace D3DotNetAPI.Utilities
{
    public static class DataUtility
    {
        public const string careerProfilePath = "/api/d3/profile/{0}-{1}/";
        public const string heroProfilePath = careerProfilePath + "/hero/{2}";
        public const string followerPath = "/api/d3/data/follower/{0}";
        public const string artisanPath = "/api/d3/data/artisan/{0}";
        public const string itemsPath = "/api/d3/data/item/{0}";

    }
}
