﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using D3DotNetAPI.Models;
using System.Runtime.Serialization.Json;
using D3DotNetAPI.Utilities;
using D3DotNetAPI.Exceptions;

namespace D3DotNetAPI
{
    public interface IExplorer
    {
        Item GetItem(string id);

        Career GetCareer(string battleTagName, int battleTagCode);

        Follower GetFollower(FollowerType type);

        Hero GetHero(string battleTagName, int battleTagCode, int heroId);
    }
}
