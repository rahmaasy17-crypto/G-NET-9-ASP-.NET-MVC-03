using GymManagement.BLL.Services.Interfaces;
using GymManagement.DAL.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace GymManagement.PL.Controllers
{
    public class MembersController : Controller
    {
        private readonly IMemberService _memberService;
        public MembersController(IMemberService memberService)
        {
            _memberService = memberService;
        }

        #region Index
        //Index() >list all members 
        //GET baseurl/Members/Index 

       public async Task<IActionResult> Index(CancellationToken c ) 
        { 
            var members= await _memberService.GetAllMemberAsync(c);
            return  View(members);   
        }

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

        [HttpGet]
        public IActionResult Create() => View();
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
