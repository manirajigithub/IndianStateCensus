using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensus.POCO
{
    public class CensusDataDAO
    {
        public string state;
        public long population, area, density;
        public CensusDataDAO(string state, string population, string area, string density)
        {
            this.state = state;
            this.population = Convert.ToUInt32(population);
            this.area = Convert.ToUInt32(area);
            this.density = Convert.ToUInt32(density);
        }
    }
}