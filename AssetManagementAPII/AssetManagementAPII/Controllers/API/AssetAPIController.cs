using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SharedModel;
using Model;



namespace AssetManagementAPII.Controllers
{
    public class AssetAPIController : ApiController
    {
        public List<Asset> Get()
        {
            using (AssetManagementEntities entities = new AssetManagementEntities())
            {
                //AssetManagementEntities entities = new AssetManagementEntities();
            
                IEnumerable<Asset> assets = entities.Assets.ToList();
                List<AssetNumbers> ass = new List<AssetNumbers>();
                foreach (var item in assets)
                {
                    ass.Add(new AssetNumbers
                    {
                        Asset_Numbers = item.Asset_Number
                    });
                }


                var result = (from item in entities.Assets select item).ToList();

                return result;
            }
        }
    }
}
