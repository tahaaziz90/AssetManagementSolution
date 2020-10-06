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
    public class BranchController : ApiController
    {
        [HttpGet]
        public IEnumerable<TreeData> getBranchTree(int companyId)
        {
            using (AssetManagementEntities entities = new AssetManagementEntities())
            {
                List<TreeData> branchFilter = new List<TreeData>();
                try
                {
                    var branches = entities.asm_getCategoryTree(companyId);
                    foreach (var bra in branches)
                    {
                        branchFilter.Add(new TreeData
                        {
                            id = bra.id,
                            text = bra.text,
                            parent = bra.parent
                        });
                    }
                    return branchFilter;
                }
                catch (Exception e)
                {

                }
                return branchFilter;
            }

        }

        [HttpGet]
        public IEnumerable<Filter> getBranchList (int companyId)
        {
            using(AssetManagementEntities entities = new AssetManagementEntities())
            {
                List<Filter> branchFilter = new List<Filter>();
                try {
                    var branches = entities.asm_getBranch(companyId);
                    foreach (var branch in branches) {
                        branchFilter.Add(new Filter {
                            id = branch.Id,
                            text= branch.Name
                        });
                    }
                    return branchFilter;
                }
                catch (Exception e)
                {
                    
                }
                return branchFilter;
            }

        }

        [HttpGet]
        public IEnumerable<branchModel> getBranchdata(string BranchCode)
        {
            List<branchModel> getbraData = new List<branchModel>();
            try
            {
                if (BranchCode != null)
                {
                    int BraCode = Convert.ToInt16(BranchCode);
                    using (AssetManagementEntities entities = new AssetManagementEntities())
                    {
                        var branches = entities.asm_getBranchdata(BraCode);

                        foreach (var bra in branches)
                        {
                            getbraData.Add(new branchModel
                            {
                                Branch_Code = bra.Branch_Code,
                                CompanyID = bra.CompanyID,
                                Branch_Name = bra.Branch_Name,
                                Country = bra.Country,
                                Contact = bra.Contact,
                                Status = bra.Status,
                                Actions = bra.Actions

                            });
                        }
                    }
                    return getbraData;
                }
            }
            catch (Exception e)
            {


            }
            return getbraData;
        }
    }
}