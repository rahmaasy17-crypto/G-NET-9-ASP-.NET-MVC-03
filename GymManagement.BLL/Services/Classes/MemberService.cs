using GymManagement.BLL.Services.Interfaces;
using GymManagement.BLL.ViewModels.MemberViewModels;
using GymManagement.DAL.Data.Models;
using GymManagement.DAL.Data.Models.Enums;
using GymManagement.DAL.Repositories.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.BLL.Services.Classes
{
    //talk with repo to get data from database
    public class MemberService : IMemberService
    {
        private readonly IGenaricReposatory<Member> _MemberReposatory;

        public MemberService(IGenaricReposatory<Member> MemberReposatory) //TO inject repo
        {
            _MemberReposatory = MemberReposatory;
        }  
        async Task<IEnumerable<MemberViewModel>> IMemberService.GetAllMemberAsync(CancellationToken c)
        {
            var members = await _MemberReposatory.GetAllAsync(c:c);

            if (!members.Any()) return [];
            var membersViewModel = members.Select(m => new MemberViewModel()
            {
                Email = m.Email,
                Gender = m.Gender.ToString(),
                Id = m.Id,
                Name = m.Name,
                Phone = m.Phone
            });
            return membersViewModel;    
        }
    }
}
