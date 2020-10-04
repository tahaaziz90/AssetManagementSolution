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
    public class CompanyController : ApiController
    {
        [HttpGet]
        public IEnumerable<Filter> getCompanyList(int Id)
        {
            using (AssetManagementEntities entities = new AssetManagementEntities())
            {
                List<Filter> companyFilter = new List<Filter>();
                try
                {
                    var companies = entities.asm_getCompany(Id);
                    foreach (var com in companies)
                    {
                        companyFilter.Add(new Filter
                        {
                            id = com.Id,
                            text = com.Name
                        });
                    }
                    return companyFilter;
                }
                catch (Exception e)
                {

                }
                return companyFilter;
            }

        }

        [HttpGet]
        public IEnumerable<companyModel> getCompanydata(string CompanyID)
        {
            List<companyModel> getcomData = new List<companyModel>();
            try
            {
                if (CompanyID != null)
                {
                    int ComID = Convert.ToInt16(CompanyID);
                    using (AssetManagementEntities entities = new AssetManagementEntities())
                    {
                        var companies = entities.asm_getCompanydata(ComID);

                        foreach (var com in companies)
                        {
                            getcomData.Add(new companyModel
                            {
                                CompanyID = com.CompanyID,
                                Company_Code = com.Company_Code,
                                Company_Name = com.Company_Name,
                                Country = com.Country,
                                Contact = com.Contact,
                                Status = com.Status,
                                Actions = com.Actions

                            });
                        }
                    }
                    return getcomData;
                }
            }
            catch (Exception e)
            {


            }
            return getcomData;
        }
    }
}