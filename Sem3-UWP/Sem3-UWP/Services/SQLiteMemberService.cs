using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sem3_UWP.Models;

namespace Sem3_UWP.Services
{
    public class SQLiteMemberService:IMemberService
    {
        private MemberModel memberModel;

        public SQLiteMemberService()
        {
            memberModel = new MemberModel();
        }

        public void Create(Member2 member)
        {
            memberModel.Save(member);
        }
        public Task<Member> Create(Member member)
        {
            throw new NotImplementedException();
        }

        public Task<List<Member>> GetList()
        {
            throw new NotImplementedException();
        }

        public Task<Member> GetDetail(string rollNumber)
        {
            throw new NotImplementedException();
        }

        public Task<Member> Update(Member member)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(string rollNumber)
        {
            throw new NotImplementedException();
        }
    }
}
