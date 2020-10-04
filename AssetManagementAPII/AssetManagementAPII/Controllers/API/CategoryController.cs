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
    public class CategoryController : ApiController
    {
        [HttpGet]
        public IEnumerable<categoryModel> getCategorydata(string categoryCode)
        {
            List<categoryModel> getcatData = new List<categoryModel>();
            try
            {
                if (categoryCode != null)
                {
                    int catCode = Convert.ToInt16(categoryCode);
                    using (AssetManagementEntities entities = new AssetManagementEntities())
                    {
                        var categories = entities.asm_getCategorydata(catCode);

                        foreach (var cat in categories)
                        {
                            getcatData.Add(new categoryModel
                            {
                                Category_Code = cat.Category_Code,
                                BranchID = cat.BranchID,
                                Location_Code = cat.Location_Code,
                                Category_Name = cat.Category_Name,
                                Actions = cat.Actions
                            });
                        }
                    }
                    return getcatData;
                }
            }
            catch (Exception e)
            {


            }
            return getcatData;
        }

        [HttpGet]
        public IEnumerable<Filter> getCategoryList(int Id, int bId)
        {
            using (AssetManagementEntities entities = new AssetManagementEntities())
            {
                List<Filter> categoryFilter = new List<Filter>();
                try
                {
                    var categories = entities.asm_getCategory(Id, bId);
                    foreach (var cat in categories)
                    {
                        categoryFilter.Add(new Filter
                        {
                            id = cat.Id,
                            text = cat.Name
                        });
                    }
                    return categoryFilter;
                }
                catch (Exception e)
                {

                }
                return categoryFilter;
            }

        }

        [HttpPost]
        public void AddCategory(CategoryAdditionModel cat)
        {
            using (AssetManagementEntities entities = new AssetManagementEntities())
            {
                entities.asm_addCategory(
                    cat.Name
                    );
            }
        }
    }

   
}