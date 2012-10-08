using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Web.Script.Serialization;
using D3DotNetAPI.Models;
using D3DotNetAPI.Utilities;
using System.Runtime.Serialization.Json;
using System.IO;
using D3DotNetAPI.Exceptions;

namespace D3DotNetAPI
{
    public enum Region
    {
        US,
        EU,
        KR,
        TW,
        CN
    }

    public enum FollowerType
    {
        scoundrel,
        enchantress,
        templar
    }

    public enum ArtisanType
    {
        blacksmith,
        jeweler
    }
      

    public class D3Explorer : IExplorer
    {
        public Region Region { get; set; }
        
        private string BaseAPIurl { get; set; }

        public ErrorInfo ErrorInfo { get; set; }

        public D3Explorer() : this(Region.US) { }

        public D3Explorer(Region region)            
        {
            Region = region;
            BaseAPIurl = ExplorerUtility.GetBaseURL(Region);
        }         
              
        
        #region Items

        public Item GetItem(string id)
        {
            Item item;

            TryGetData<Item>(BaseAPIurl + string.Format(DataUtility.itemsPath, id), out item);

            return item;
        }

        #endregion

        #region Career

        public Career GetCareer(string battleTagName, int battleTagCode)
        {
            Career career;

            TryGetData<Career>(BaseAPIurl + string.Format(DataUtility.careerProfilePath, battleTagName, battleTagCode), out career);

            return career;
        }

        #endregion

        #region Follower

        public Follower GetFollower(FollowerType type)
        {
            Follower follower;

            TryGetData<Follower>(BaseAPIurl + string.Format(DataUtility.followerPath, type), out follower);

            return follower;
        }

        #endregion

        #region Artisan

        public Artisan GetArtisan(ArtisanType type)
        {
            Artisan artisan;

            TryGetData<Artisan>(BaseAPIurl + string.Format(DataUtility.artisanPath, type), out artisan);

            return artisan;
        }

        #endregion

        #region Hero

        public Hero GetHero (string battleTagName, int battleTagCode, long heroId)
        {
            Hero hero;

            TryGetData<Hero>(BaseAPIurl + string.Format(DataUtility.heroProfilePath, battleTagName, battleTagCode, heroId), out hero);

            return hero;
        }

        #endregion


        private T GetData<T>(string url) where T : class
        {
            return JsonUtility.FromJSON<T>(url);
        }

        private void TryGetData<T>(string url, out T requestedObject) where T : class
        {
            try
            {
                requestedObject = JsonUtility.FromJSON<T>(url);
            }
            catch (D3Exception wowEx)
            {
                ErrorInfo = new ErrorInfo
                {
                    ErrorDetail = wowEx.ErrorDetail,
                    OriginalException = wowEx.OriginalException,
                    RequestUrl = wowEx.Url
                };
                requestedObject = null;
            }
            catch (WebException webEx)
            {
                ErrorInfo = new ErrorInfo
                {
                    ErrorDetail = null,
                    OriginalException = webEx,
                    RequestUrl = string.Empty
                };
                requestedObject = null;
            }
            catch (Exception ex)
            {
                ErrorInfo = new ErrorInfo
                {
                    ErrorDetail = null,
                    OriginalException = ex,
                    RequestUrl = string.Empty
                };
                requestedObject = null;
            }
        }
    }
}
