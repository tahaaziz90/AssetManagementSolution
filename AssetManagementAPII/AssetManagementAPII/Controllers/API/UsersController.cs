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
    public class UsersController : ApiController
    {
        
        public void userData()
        {
            using (AssetManagementEntities entities = new AssetManagementEntities())
            {

            }
        } 

        [HttpGet]
        public IEnumerable<userModel> GetUser(string Id)
        {
            List<userModel> getU = new List<userModel>();

            try
            {
                if (Id != null)
                {
                    int UserID = Convert.ToInt16(Id);
                    using (AssetManagementEntities entities = new AssetManagementEntities())
                    {
                        var Users = entities.asm_getUsers1(UserID);
                        foreach (var u in Users)
                        {
                            getU.Add(new userModel
                            {
                                UserID = u.UserID,
                                userName = u.User_Name,
                                password = u.Password,
                                firstName = u.First_Name,
                                lastName = u.Last_Name,
                                Email = u.Email,
                                pin = u.PIN,
                                designation = u.Designation,
                                status = u.Status,
                                actions = u.Actions

                            });
                        }
                    }
                    return getU;
                }
            }
            
            catch (Exception e)
            {

                
            }
            return getU;
        }

        [HttpPost]
        public void AddUser(userAdditionModel user)
        {
            using (AssetManagementEntities entities = new AssetManagementEntities())
            {
                entities.asm_addUser(
                    user.UserName,
                    user.Password,
                    user.firstName,
                    user.lastName,
                    user.Email,
                    user.contactNumber,
                    user.mobileNumber,
                    user.userAddress,
                    user.designation
                    );
            }
        }
    }
}