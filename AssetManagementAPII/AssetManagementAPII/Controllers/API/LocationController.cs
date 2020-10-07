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
    public class LocationController : ApiController
    {
        //public void LocationAddition()
        //{
        //    using (AssetManagementEntities entities = new AssetManagementEntities())
        //    {

        //    }
        //}

        [HttpGet]
        public void DeleteLocation(int Id) {
            using (AssetManagementEntities entities = new AssetManagementEntities()) {
                var deleted = entities.asm_deleteLocation(Id);
            }
        }


        [HttpGet]
        public IEnumerable<Filter> getLocationList(int Id, int bId)
        {
            using (AssetManagementEntities entities = new AssetManagementEntities())
            {
                List<Filter> locationFilter = new List<Filter>();
                try
                {
                    var locations = entities.asm_getLocations(Id, bId);
                    foreach (var loc in locations)
                    {
                        locationFilter.Add(new Filter
                        {
                            id = loc.Id,
                            text = loc.Name
                        });
                    }
                    return locationFilter;
                }
                catch (Exception e)
                {

                }
                return locationFilter;
            }

        }

        [HttpGet]
        public IEnumerable<TreeData> getLocationTree(int bId)
        {
            using (AssetManagementEntities entities = new AssetManagementEntities())
            {
                List<TreeData> locationFilter = new List<TreeData>();
                try
                {
                    var locations = entities.asm_getLocationTree(bId);
                    foreach (var loc in locations)
                    {
                        locationFilter.Add(new TreeData
                        {
                            id = loc.id,
                            text = loc.text,
                            parent = loc.parent
                        });
                    }
                    return locationFilter;
                }
                catch (Exception e)
                {

                }
                return locationFilter;
            }

        }

        [HttpGet]
        public IEnumerable<locationModel> getLocationdata(string locationCode)
        {
            List<locationModel> getlocData = new List<locationModel>();
            try
            {
                if (locationCode != null)
                {
                    int LocCode = Convert.ToInt16(locationCode);
                    using (AssetManagementEntities entities = new AssetManagementEntities())
                    {
                        var locations = entities.asm_getLocationdata1(LocCode);

                        foreach (var locdat in locations)
                        {
                            getlocData.Add(new locationModel
                            {
                                Location_Code = locdat.Location_Code,
                                Location_Name = locdat.Location_Name,
                                Parent_ID = locdat.Parent_ID,
                                CreatedOn = locdat.CreatedOn,
                                ModifiedOn = locdat.ModifiedOn,
                                Actions = locdat.Actions
                            });
                        }
                    }
                    return getlocData;    
                }
            }
            catch (Exception e)
            {

                
            }
            return getlocData;
        }

        [HttpPost]
        public int AddLocation(LocationAdditionModel addLocation)
        {
            List<returnID> newID = new List<returnID>();
            int ParentID = Convert.ToInt16(addLocation.Parent_ID);
            int BranchID = Convert.ToInt16(addLocation.Branch_ID);
            using (AssetManagementEntities entities = new AssetManagementEntities())
            {
                var inserted = entities.asm_addLocation(
                    addLocation.Location_Name,
                   ParentID,
                   BranchID
                    );
                foreach(var id in inserted)
                {
                    newID.Add(new returnID
                    {
                        Id = id.Id
                    });
                }
                return newID.FirstOrDefault().Id;
            }
        }

    }
}
