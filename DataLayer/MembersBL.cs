using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class MembersBL:BaseClass
    {
        public void AddMember(string first, string last, string email, string phone, string address,
            string address2, string city, string state, string zip)
        {
            Member m = new Member();
            m.FirstName = first;
            m.LastName = last;
            m.Email = email;
            m.Phone = phone;
            m.Address = address;
            m.Address2 = address2;
            m.City = city;
            m.State = state;
            m.Zip = zip;
            m.IsAtive = true;
            m.DateAdded = DateTime.Now;
            Dataservice.Members.InsertOnSubmit(m);
            Dataservice.SubmitChanges();
        }
        public void UpDateMember(int id, string first, string last, string email, string phone, string address,
            string address2, string city, string state, string zip, bool ative)
        {
            Member m = Dataservice.Members.SingleOrDefault(c => c.Id == id);
            m.FirstName = first;
            m.LastName = last;
            m.Email = email;
            m.Phone = phone;
            m.Address = address;
            m.Address2 = address2;
            m.City = city;
            m.State = state;
            m.Zip = zip;
            m.IsAtive = ative;
            Dataservice.SubmitChanges();
        }

        public Member GetCurrentUser(int userId)
        {
            return Dataservice.Members.SingleOrDefault(c => c.Id == userId);
        }

        public List<Member> GetMemberList()
        {
            return Dataservice.Members.OrderByDescending(c => c.LastName).ToList();
        }

    }
}
