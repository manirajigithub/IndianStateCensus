using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensus.POCO
{
    public class StateCodeDAO
    {
        public int serialNumber, tin;
        public string stateName, stateCode;
        public StateCodeDAO(string serialNumber, string tin, string stateName, string stateCode)
        {
            this.serialNumber = Convert.ToInt32(serialNumber);
            this.tin = Convert.ToInt32(tin);
            this.stateName = stateName;
            this.stateCode = stateCode;
        }
    }
}
