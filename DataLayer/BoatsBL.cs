using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class BoatsBL: BaseClass
    {
        public void AddBoat(string name, string hullNum, int powerId, int memberId, int size)
        {
            Boat b = new Boat();
            b.Name = name;
            b.HullNumber = hullNum;
            b.PowerId = powerId;
            b.MemberId = memberId;
            b.Size = size;
            Dataservice.Boats.InsertOnSubmit(b);
            Dataservice.SubmitChanges();
        }
        public void UpdateBoat(int id, string name, string hullNum, int powerId, int memberId, int size, bool deleted)
        {
            Boat b = Dataservice.Boats.SingleOrDefault(c => c.Id == id);
            b.Name = name;
            b.HullNumber = hullNum;
            b.PowerId = powerId;
            b.MemberId = memberId;
            b.Size = size;
            b.IsDeleted = deleted;
            Dataservice.SubmitChanges();
        }
        public List<Boat> GetBoatsList()
        {
            return Dataservice.Boats.OrderByDescending(c => c.Id).ToList();
        }
    }
}
