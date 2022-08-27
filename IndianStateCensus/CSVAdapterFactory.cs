using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndianStateCensus.POCO;
using IndianStateCensus.DTO;

namespace IndianStateCensus
{
    public class CSVAdapterFactory
    {
        public Dictionary<string, CensusDTO> LoadCsvData(IndianStateCensus.CensusAnalyser.Country country, string csvFilePath, string dataHeaders)
        {
            switch (country)
            {
                case (IndianStateCensus.CensusAnalyser.Country.INDIA):
                    return new indianCensusAdapter().LoadCensusData(csvFilePath, dataHeaders);
                default:
                    throw new CensusAnalyserException("No such country", CensusAnalyserException.ExceptionType.NO_SUCH_COUNTRY);
            }

        }
    }
}