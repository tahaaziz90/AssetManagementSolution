using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModel
{
    public class Filter
    {

        public int id { get; set; }
        public string text { get; set; }

    }

    public class userAdditionModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string Email { get; set; }
        public string contactNumber { get; set; }
        public string mobileNumber { get; set; }
        public string designation { get; set; }
        public string userAddress { get; set; }
    }

    public class LocationAdditionModel {
        public string Name { get; set; }
    }

    public class CategoryAdditionModel {
        
        public string Name { get; set; }
    }

    public class userModel
    {
        public int UserID { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string Email { get; set; }
        public Nullable<int> pin { get; set; }
        public string designation { get; set; }
        public string status { get; set; }
        public string actions { get; set; }

    }

    public class locationModel
    {
        public int Branch_ID { get; set; }
        public int Location_Code { get; set; }
        public string Location_Name { get; set; }
        public int Parent_ID { get; set; }
        public string CreatedOn { get; set; }
        public string ModifiedOn { get; set; }
        public string Actions { get; set; }
    }

    public class categoryModel
    {
        public int Category_Code { get; set; }
        public int BranchID { get; set; }
        public int Location_Code { get; set; }
        public string Category_Name { get; set; }
        public string Actions { get; set; }
    }

    public class companyModel
    {
        public int CompanyID { get; set; }
        public string Company_Code { get; set; }
        public string Company_Name { get; set; }
        public int Country { get; set; }
        public string Contact { get; set; }
        public bool Status { get; set; }
        public string Actions { get; set; }
    }

    public class branchModel
    {
        public string Branch_Code { get; set; }
        public int CompanyID { get; set; }
        public string Branch_Name { get; set; }
        public int Country { get; set; }
        public string Contact { get; set; }
        public bool Status { get; set; }
        public string Actions { get; set; }
    }

    public class assetModel
    {
        public int AssetID { get; set; }
        public int BranchID { get; set; }
        public int Location_Code { get; set; }
        public int Category_Code { get; set; }
        public int PurchaseID { get; set; }
        public string RFID_Tag { get; set; }
        public string Barcode { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string Actions { get; set; }
    }
}
