using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asm
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string UserType { get; set; }
        public double LastMonthWaterMeter { get; set; }
        public double ThisMonthWaterMeter { get; set; }
        public double TotalBill { get; private set; }

        public User()
        {
            ID = 0;
            Name = "";
            UserType = "";
            LastMonthWaterMeter = 0;
            ThisMonthWaterMeter = 0;
            TotalBill = 0;
        }

        public User(int id, string name,string userType, double lastMonthWaterMeter, double thisMonthWaterMater, double total)
        {
            ID = id;
            Name = name;
            UserType = userType;
            LastMonthWaterMeter = lastMonthWaterMeter;
            ThisMonthWaterMeter = thisMonthWaterMater;
            //total = ThisMonthWaterMeter - LastMonthWaterMeter;
            TotalBill = total;
        }
        
    }
    
}
