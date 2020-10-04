using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Model;
using SharedModel;

namespace AssetManagementAPII.Controllers.API
{
    public class AssetdataController : ApiController
    {
        [HttpGet]
        public IEnumerable<assetModel> getAssetdata(string AssetID)
        {
            List<assetModel> getassData = new List<assetModel>();
            try
            {
                if (AssetID != null)
                {
                    int assID = Convert.ToInt16(AssetID);
                    using (AssetManagementEntities entities = new AssetManagementEntities())
                    {
                        var Assets = entities.asm_getAssetdata(assID);

                        foreach (var ass in Assets)
                        {
                            getassData.Add(new assetModel
                            {
                                AssetID = ass.AssetID,
                                BranchID = ass.BranchID,
                                Location_Code = ass.Location_Code,
                                Category_Code = ass.Category_Code,
                                PurchaseID = ass.PurchaseID,
                                RFID_Tag = ass.RFID_Tag,
                                Barcode = ass.Barcode,
                                CreatedOn = ass.CreatedOn,
                                Actions = ass.Actions
                            });
                        }
                    }
                    return getassData;
                }
            }
            catch (Exception e)
            {


            }
            return getassData;
        }
    }
}