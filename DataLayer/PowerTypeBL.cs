using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class PowerTypeBL:BaseClass
    {
        public List<PowerType> GetPowerTypesList()
        {
            return Dataservice.PowerTypes.OrderByDescending(c => c.Id).ToList();
        }
        public List<PowerType> GetPowerTypesListBYId(int id)
        {
            return Dataservice.PowerTypes.Where(c =>c.Id == id).OrderByDescending(c => c.Id).ToList();
        }
    }
}
