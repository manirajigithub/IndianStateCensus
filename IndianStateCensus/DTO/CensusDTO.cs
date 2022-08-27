using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndianStateCensus.POCO;


namespace IndianStateCensus.DTO
{
    public class CensusDTO
    {

        public int serialNumber, tin;
        public string stateName, state, stateCode;
        public long population, area, density, housingUnits;
        public double totalArea, waterArea, landArea, populationDensity, housingDensity;
        public CensusDTO(StateCodeDAO statecodeDao)
        {
            this.serialNumber = statecodeDao.serialNumber;
            this.stateName = statecodeDao.stateName;
            this.tin = statecodeDao.tin;
            this.stateCode = statecodeDao.stateCode;
        }
        public CensusDTO(CensusDataDAO censusDataDAO)
        {
            this.state = censusDataDAO.state;
            this.population = censusDataDAO.population;
            this.area = censusDataDAO.area;
            this.density = censusDataDAO.density;
        }
    }
}