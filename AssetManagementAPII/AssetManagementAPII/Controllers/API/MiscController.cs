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
    public class MiscController : ApiController
    {
        [HttpGet]
        public IEnumerable<Filter> getCountryList(int Id)
        {
            using (AssetManagementEntities entities = new AssetManagementEntities())
            {
                List<Filter> countryFilter = new List<Filter>();
                try
                {
                    var countries = entities.asm_getCountry(Id);
                    foreach (var con in countries)
                    {
                        countryFilter.Add(new Filter
                        {
                            id = con.Id,
                            text = con.Name
                        });
                    }
                    return countryFilter;
                }
                catch (Exception e)
                {

                }
                return countryFilter;
            }

        }
    }
}