using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class LocationsBL:BaseClass
    {
        public void AddLocation(string name, string state, string GPS, bool coast, int fishId)
        {
            Location l = new Location();
            l.Name = name;
            l.State = state;
            l.GPS = GPS;
            l.IsCoast = coast;
            l.FishId = fishId;
            Dataservice.Locations.InsertOnSubmit(l);
            Dataservice.SubmitChanges();
        }
        public void UpdateLocation(int id,string name, string state, string GPS, bool coast, int fishId)
        {
            Location l = Dataservice.Locations.SingleOrDefault(c => c.Id == id);
            l.Name = name;
            l.State = state;
            l.GPS = GPS;
            l.IsCoast = coast;
            l.FishId = fishId;
            Dataservice.SubmitChanges();
        }
        public List<Location> GetLocationsList()
        {
            return Dataservice.Locations.OrderByDescending(c => c.State).ToList();
        }
        public List<Location> GetLocationsListById(int id)
        {
            return Dataservice.Locations.Where(c=>c.Id == id).OrderByDescending(c => c.State).ToList();
        }
    }
}
