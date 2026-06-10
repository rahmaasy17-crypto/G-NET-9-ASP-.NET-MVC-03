using Microsoft.AspNetCore.Mvc;

namespace GymManagement.PL.Controllers
{
    public class MembersController : Controller
    {
        #region Index
        //Index() >list all members 
        //GET baseurl/Members/Index 


        #endregion

        #region MemberDetails
        //MemberDetails(int id)  >for 1 member
        //GET baseurl/Members/MemberDetails/{id} 
        #endregion

        #region HealthRecordDetails
        //HealthRecordDetails(int id)   >for HealthRecord Detail for 1 member
        //GET baseurl/Members/HealthRecordDetails/{id} 
        #endregion

        #region Createing Member > 2 steps
        //Create() >show empty form 
        //GET baseurl/Members/Create

        //CreateMember() >subbmit form 
        //post baseurl/Members/Create{Members} 
        #endregion

        #region Editing Member > 2 steps

        //MemberEdit(int id >disply edit form (have data)
        //GET baseurl/Members/MemberEdit/{id}

        //MemberEdit(int id >subbmit form 
        //post baseurl/Members/MemberEdit{Members} 
        #endregion


        #region DeletingMember > 2 steps
        //Delete(int id) >show form 
        //GET baseurl/Members/Delete/{id} 

        //DeleteConfirmed(int id) >subbmit form 
        //post baseurl/Members/DeleteConfirmed/{id} 
        #endregion

    }
}
