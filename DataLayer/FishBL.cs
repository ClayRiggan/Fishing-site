using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class FishBL:BaseClass
    {
        public void AddFish(decimal length, decimal weight, string type, int loactionId, string notes, int boatId,
            int memberId)
        {
            Fish f = new Fish();
            f.Length = length;
            f.Weight = weight;
            f.Type = type;
            f.LocationId = loactionId;
            f.BoatId = boatId;
            f.MemberId = memberId;
            Dataservice.Fishes.InsertOnSubmit(f);
            Dataservice.SubmitChanges();
        }
        public void UpdateFish(int id, decimal lenght, decimal weight, string type, int loactionId, string notes, int boatId,
            int memberId, bool deleted)
        {
            Fish f = Dataservice.Fishes.SingleOrDefault(c => c.Id == id);
            f.Length = lenght;
            f.Weight = weight;
            f.Type = type;
            f.LocationId = loactionId;
            f.BoatId = boatId;
            f.MemberId = memberId;
            f.IsDeleted = deleted;
            Dataservice.SubmitChanges();
        }
        public List<Fish> GetFishList()
        {
            return Dataservice.Fishes.OrderByDescending(c => c.DateCaught).ToList();
        }
        public Fish GetFish(int Id, int Member)
        {
            return Dataservice.Fishes.SingleOrDefault(c => c.Id == Id && c.MemberId == Member);
        }
    }
}
