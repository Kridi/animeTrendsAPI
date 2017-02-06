using System;
using System.Collections.Generic;
using System.Web.Http;
using AnimeTrendsAPI.Data;
using AnimeTrendsAPI.Models;

namespace AnimeTrendsAPI.Controllers
{
    public class MembersController : ApiController
    {
        // GET api/values 
        public List<Member> Get()
        {
            return MemberData.MemberList;
        }
        public void Post([FromBody] Member member)
        {
            member.Date = DateTime.Now.ToShortTimeString();
            MemberData.MemberList.Add(member);
        }
    }
}