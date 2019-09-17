using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class BaseClass
    {
        public PondFishDataDataContext Dataservice;

        public BaseClass()
        {
            Dataservice = new PondFishDataDataContext();
            Dataservice.CommandTimeout = 0;
        }
        public string MD5Hash(string inputString)
        {
            byte[] input = Encoding.UTF8.GetBytes(inputString);
            byte[] output = MD5.Create().ComputeHash(input);
            return Convert.ToBase64String(output);
        }
    }
}
